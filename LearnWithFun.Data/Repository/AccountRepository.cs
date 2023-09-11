using LearnWithFun.Data.IRepository;
using LearnWithFun.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Repository
{
	public class AccountRepository : IAccountRepository
	{
		private readonly DapperContext _context;
		public AccountRepository(DapperContext context)
		{
			_context = context;
		}
		public int CreateAccount(LearnerModel Model)
		{
			throw new NotImplementedException();
		}

		public LearnerModel Login(LoginModel Model)
		{
			throw new NotImplementedException();
		}
	}
}
