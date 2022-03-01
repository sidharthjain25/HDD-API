using System.ComponentModel.DataAnnotations;

namespace HDD.Entities
{
    public class BaseEntity
    {
        [Key]
        public long ID { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public void Audit(string userName)
        {
            this.ModifiedBy = userName;
            this.ModifiedDate = DateTime.Now;
        }

        public void CreateAudit(string userName)
        {
            this.CreatedBy = this.ModifiedBy=userName;
            this.CreatedDate =this.ModifiedDate = DateTime.Now;
            
        }

    }
}