using BookLibrary.Models;
using System.Collections.Generic;

namespace BookLibrary.ModelViews
{
	public class ProductHomeVM
	{
		public Category category { get; set; }
		public List<Product> lsProducts { get; set; }
		public int CurrentPage { get; set; } // Trang hiện tại
		public int TotalPages { get; set; } // Tổng số trang

	}

}
