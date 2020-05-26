using System.Collections.Generic;

namespace dmc_tasks.Entities
{
    public class Department : BaseEntity
    {
        public string Code { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }

        public string Location { get; set; }
        public string Location2 { get; set; }
        public string Location3 { get; set; }

        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public int? ParentID {get;set;}
        public Department Parent {get;set;}

        public ICollection<Department> Children {get;set;}
        public ICollection<DepartmentRelation> DepartmentRelations {get;set;}
    }
}
