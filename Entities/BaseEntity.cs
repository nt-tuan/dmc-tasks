using System;
namespace dmc_tasks.Entities
{
    public abstract class BaseEntity {
        public int ID {get;set;}
        public string CreatedBy {get;set;}
        public string ModifiedBy {get;set;}
        public string DeletedBy {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime? ModefieddAt {get;set;}
        public DateTime? DeletedAt {get;set;}
    }
}