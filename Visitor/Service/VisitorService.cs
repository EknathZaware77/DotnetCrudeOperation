using Visitor.Data;
using Visitor.Model;

namespace Visitor.Service
{
    public class VisitorService : IVisitService
    {

        public MyDbContext Context;
        public VisitorService(MyDbContext context) {  Context = context; }

        void IVisitService.AddVisitor(Visit visit)
        {
            try
            {
                Context.Visitors.Add(visit);
                Context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(" error ");
            }
        }

        Visit IVisitService.getBYId(int id)
        {
            try
            {
                return Context.Visitors.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(" error ");
            }
        }

        void IVisitService.RemoveVisitor(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(" error ");
            }
        }

        void IVisitService.UpdateVistor(Visit visit)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(" error ");
            }
        }

        List<Visit> IVisitService.visit()
        {
            try
            {
                return Context.Visitors.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(" error ");
            }
        }
    }
}
