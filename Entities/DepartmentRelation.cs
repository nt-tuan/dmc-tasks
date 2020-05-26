
namespace dmc_tasks.Entities
{
    public class DepartmentRelation : BaseEntity
    {
        public int AncestorID {get;set;}
        public Department Ancestor {get;set;}
        public int DescendantID {get;set;}
        public Department Descendant {get;set;}
        public int level {get;set;}
    }
}
