using System;

namespace BookLibrary.Models
{
    public partial class TblTinTuc
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Scontents { get; set; }
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public bool Published { get; set; }
        public string Alias { get; set; }
        public DateTime? CreateDate { get; set; }

        // Khóa ngoại cho tác giả
        public int? AuthorId { get; set; }  // Thêm AuthorId vào đây

        public Author Author { get; set; } // Đối tượng tác giả

        public int? AccountId { get; set; }
        public string Tags { get; set; }
        public int? CatId { get; set; }
        public bool? isHot { get; set; }
        public bool? isNewfeed { get; set; }
        public string MetaKey { get; set; }
        public string MetaDesc { get; set; }
        public int? Views { get; set; }
    }
}
