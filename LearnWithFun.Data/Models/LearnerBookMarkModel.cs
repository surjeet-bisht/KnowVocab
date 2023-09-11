using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class LearnerBookMarkModel : Base
	{
		public int LearnerBookMarkID { get; set; }
		public int? ArticleID { get; set; }
		public int? LearnerID { get; set; }
	}
}
