namespace MyFrameWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserDevices
    {
        [Key]
        public long DeviceId { get; set; }

        public int? UserId { get; set; }

        public DateTime? ActiveTime { get; set; }

        public DateTime? ExpiredTime { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? DeviceType { get; set; }

        [StringLength(32)]
        public string SessionKey { get; set; }
    }
}
