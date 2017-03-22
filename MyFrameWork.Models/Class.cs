namespace MyFrameWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        public int ClassID { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }
    }
}
