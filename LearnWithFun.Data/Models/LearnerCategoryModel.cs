using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class LearnerCategoryModel : Base
	{
		public int LearnerCategoryID { get; set; }
		public int? LearnerID { get; set; }
		public int? CategoryID { get; set; }
	}
}
