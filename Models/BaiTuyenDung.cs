using System;
using System.Collections.Generic;

#nullable disable

namespace BtlJobFinderVT.Models
{
    public partial class BaiTuyenDung
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public bool Published { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Author { get; set; }
        public int? AccountId { get; set; }
        public int? CatId { get; set; }
        public bool IsNewfeed { get; set; }
        public int? UserId { get; set; }

        public virtual TaiKhoan Account { get; set; }
        public virtual DanhMucCv Cat { get; set; }
        public virtual NguoiDung User { get; set; }
    }
}
