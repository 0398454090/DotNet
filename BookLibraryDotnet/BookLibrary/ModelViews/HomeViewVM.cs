using BookLibrary.Models;
using PagedList.Core;
using System.Collections.Generic;

namespace BookLibrary.ModelViews
{
    public class HomeViewVM
    {
		public List<ProductHomeVM> Products { get; set; }
		public List<Page> Pages { get; set; }
		
	}
}
