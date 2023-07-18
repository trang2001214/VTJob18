using System;
using System.Collections.Generic;

#nullable disable

namespace BtlJobFinderVT.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            BaiTuyenDungs = new HashSet<BaiTuyenDung>();
        }

        public int AccountId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? RoleId { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Salt { get; set; }

        public virtual Quyen Role { get; set; }
        public virtual ICollection<BaiTuyenDung> BaiTuyenDungs { get; set; }
    }
}
