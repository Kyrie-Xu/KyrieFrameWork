namespace MyFrameWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }

        public int ClassID { get; set; }
    }
}
