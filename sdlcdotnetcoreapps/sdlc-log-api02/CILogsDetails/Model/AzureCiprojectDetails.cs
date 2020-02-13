using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CILogsDetails.Model
{
    [Table("Azure_CIProjectDetails")]
    public partial class AzureCiprojectDetails
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Meta { get; set; }
        [Required]
        [StringLength(100)]
        public string Project { get; set; }
        [Required]
        [StringLength(100)]
        public string Org { get; set; }
        [StringLength(100)]
        public string Branch { get; set; }
        [StringLength(512)]
        public string ProjectPath { get; set; }
        [StringLength(512)]
        public string BuildConfiguration { get; set; }
        [StringLength(150)]
        public string AppOwner { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OnboardedOn { get; set; }
    }
}
