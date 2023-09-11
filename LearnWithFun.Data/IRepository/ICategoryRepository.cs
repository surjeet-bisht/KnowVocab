using LearnWithFun.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.IRepository
{
	public interface ICategoryRepository
	{
		public Task<IEnumerable<CategoryModel>> GetCategories();
	}
}
