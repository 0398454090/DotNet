using System;
using System.Collections.Generic;

#nullable disable

namespace BookLibrary.Models
{
    public partial class AuthorProduct
    {
        public int? ProductId { get; set; }
        public int? PageID { get; set; }

        public virtual Page Page { get; set; }
        public virtual Product Product { get; set; }
      
    }
}
