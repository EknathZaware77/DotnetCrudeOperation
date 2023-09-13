
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Crudeapp2.Models;
using MySqlX.XDevAPI.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

namespace Crudeapp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DepartmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

      






        [HttpGet]
        public string Get()
        {
            string query = @"
                        select * from 
                        mydb.Department
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            String result = Newtonsoft.Json.JsonConvert.SerializeObject(table);
            Console.WriteLine(result);
            return result;
           

        }







        [HttpPost]
        public JsonResult Post(int departmentId, string DepartmentName)
        {
            string query = @"
                        insert into mydb.Department (ID,DeptName) values
                        (@DepartmentId,@DepartmentName);
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlCommand myCommand;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                myCommand = new MySqlCommand(query, mycon);
                myCommand.Parameters.AddWithValue("@DepartmentId", departmentId);
                myCommand.Parameters.AddWithValue("@DepartmentName", DepartmentName);

                myCommand.ExecuteNonQuery();

                mycon.Close();
            }

            return new JsonResult("Added Successfully");
        }






        [HttpPut]
        public JsonResult Put(Department dep)
        {
            string query = @"
                        update mydb.Department set 
                        DeptName = @DepartmentName
                        where Id = @DepartmentId;" ;
         
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@DepartmentId", dep.DepartmentId);
                    myCommand.Parameters.AddWithValue("@DepartmentName", dep.DepartmentName);
                    myCommand.ExecuteNonQuery();


                    mycon.Close();
                }
            }

            return new JsonResult("Updated Successfully");

        }










        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                        delete from mydb.Department 
                        where Id = @Id;
                        
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }
    }
}
