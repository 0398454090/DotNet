using System;
using System.Collections.Generic;

#nullable disable

namespace BookLibrary.Models
{
    public partial class Page
    {
        public int PageId { get; set; }  // Đây là khóa chính
        public string PageName { get; set; }
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public bool Published { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public DateTime? CreateDate { get; set; }  // Thay đổi thành DateTime? để cho phép null
        public int Ordering { get; set; }
    }

}
