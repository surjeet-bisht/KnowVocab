using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class LearnerArticleLogModel : Base
	{
		public int LearnerArticleLogID { get; set; }
		public int? LearnerID { get; set; }
		public int? ArticleID { get; set; }
		public DateTime ArticleStartTime { get; set; }
	}
}
