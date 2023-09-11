using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class ArticleReviewModel:Base
	{
		public int ArticleReviewID { get; set; }
		public int? ArticleID { get; set; }
		public int? LearnerID { get; set; }
	}
}
