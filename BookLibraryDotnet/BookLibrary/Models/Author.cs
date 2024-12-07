using System.Collections.Generic;

namespace BookLibrary.Models
{
    public partial class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public ICollection<TblTinTuc> TinTucs { get; set; } // Mối quan hệ một-nhiều
    }
}
