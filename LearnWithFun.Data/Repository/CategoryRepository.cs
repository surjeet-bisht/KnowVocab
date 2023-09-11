using LearnWithFun.Data.Models;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using LearnWithFun.Data.IRepository;
using Dapper;

namespace LearnWithFun.Data.Repository
{
	public class CategoryRepository: ICategoryRepository
	{
		private readonly DapperContext _context;
		public CategoryRepository(DapperContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<CategoryModel>> GetCategories()
		{
			var query = "SELECT * FROM Category Where Active = 1";
			using (var connection = _context.CreateConnection())
			{
				var categories = await connection.QueryAsync<CategoryModel>(query);
				return categories.ToList();
			}
		}
	}
}
