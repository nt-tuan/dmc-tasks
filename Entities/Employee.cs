
namespace dmc_tasks.Entities
{
    public class Employee:BaseEntity
    {
        public string Code { get; set; }
        public int? DepartmentId { get; set; }
        public string EmloyeeTitle {get;set;}
        public string AppUserId { get; set; }

        public bool HasAccount()
        {
            return string.IsNullOrEmpty(AppUserId);
        }
    }
}
