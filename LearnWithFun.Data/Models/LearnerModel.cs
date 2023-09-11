using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class LearnerModel
	{
		public int LearnerID { get; set; }
		public string? FullName { get; set; }
		public string? Email { get; set; }
		public string? MobileNo { get; set; }
		public string? Password { get; set; }
		public string? Photo { get; set; }
		public string? LoginType { get; set; }
		public DateTime CreatedOn { get; set; }
		public Boolean Active { get; set; }
		public string? UpdatedBy { get; set; }
		public DateTime LastUpdated { get; set; }
	}
	public class LoginModel
	{
		public string? Email { get; set; }
		public string? LoginType { get; set; }
	}
}
