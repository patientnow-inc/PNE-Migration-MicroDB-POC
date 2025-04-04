using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PNE_Microservice_POC.Models
{
    [Table("customer")]
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("tenant_id")]
        public int TenantId { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("customer_short")]
        [MaxLength(50)]
        public string? CustomerShort { get; set; }

        [Column("first_name")]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [Column("last_name")]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Column("middle_name")]
        [MaxLength(100)]
        public string? MiddleName { get; set; }

        [Column("email")]
        [MaxLength(255)]
        public string? Email { get; set; }

        [Column("deleted")]
        public bool Deleted { get; set; } = false;

        [Column("imported")]
        public bool Imported { get; set; } = false;

        [Column("import_id")]
        [MaxLength(255)]
        public string? ImportId { get; set; }

        [Column("is_bounced_email")]
        public bool IsBouncedEmail { get; set; } = false;

        [Column("customer_number")]
        [MaxLength(50)]
        public string? CustomerNumber { get; set; }

        [Column("gender")]
        [MaxLength(50)]
        public string? Gender { get; set; }

        [Column("birthday")]
        public DateTime? Birthday { get; set; }

        [Column("anniversary")]
        public DateTime? Anniversary { get; set; }

        [Column("country_code")]
        [MaxLength(10)]
        public string? CountryCode { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Column("updated_on")]
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }

}
