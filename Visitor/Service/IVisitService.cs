using Visitor.Model;

namespace Visitor.Service
{
    public interface IVisitService
    {
        public void AddVisitor(Visit visit);
        public void RemoveVisitor(int id);

        public Visit getBYId(int id);

        public List<Visit> visit();

        public void UpdateVistor(Visit visit);







    }
}
