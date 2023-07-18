using System;
using System.Collections.Generic;

#nullable disable

namespace BtlJobFinderVT.Models
{
    public partial class Quyen
    {
        public Quyen()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
