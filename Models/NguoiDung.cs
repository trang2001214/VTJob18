using System;
using System.Collections.Generic;

#nullable disable

namespace BtlJobFinderVT.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            BaiTuyenDungs = new HashSet<BaiTuyenDung>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<BaiTuyenDung> BaiTuyenDungs { get; set; }
    }
}
