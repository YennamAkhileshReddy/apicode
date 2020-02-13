using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CILogsDetails.Model
{
    [Table("Azure_CILogsDetails")]
    public partial class AzureCilogsDetails
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Meta { get; set; }
        [Required]
        [StringLength(100)]
        public string Project { get; set; }
        [StringLength(100)]
        public string Org { get; set; }
        [Required]
        [StringLength(50)]
        public string EventType { get; set; }
        [StringLength(50)]
        public string BuildNumber { get; set; }
        [StringLength(50)]
        public string BuildId { get; set; }
        [StringLength(150)]
        public string BuildRequester { get; set; }
        [StringLength(150)]
        public string BuildRepoName { get; set; }
        [StringLength(150)]
        public string BuildDefinitionName { get; set; }
        [StringLength(50)]
        public string BuildBy { get; set; }
        [StringLength(50)]
        public string BuildRepositoryId { get; set; }
        [StringLength(50)]
        public string BuildRepositoryName { get; set; }
        [StringLength(50)]
        public string DeplyStagename { get; set; }
        [StringLength(50)]
        public string DeplyEnvironmentName { get; set; }
        [StringLength(150)]
        public string DeplySubscriptionName { get; set; }
        [StringLength(256)]
        public string DeplyAppServiceName { get; set; }
        [StringLength(50)]
        public string DeplyAppSlotName { get; set; }
        [StringLength(50)]
        public string DeplyResourceGrpName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeplyStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeplyEndTime { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(150)]
        public string Approver { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApprovedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveRequestedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
    }
}
