using System;
using System.Collections.Generic;

#nullable disable

namespace BookLibrary.Models
{
    public partial class AttributesPrice
    {
        public string AttributesPriceId { get; set; }
        public string AttributeId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public bool Active { get; set; }

        public virtual Attribute Attribute { get; set; }
    }
}
