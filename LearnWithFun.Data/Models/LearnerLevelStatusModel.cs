using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class LearnerLevelStatusModel : Base
	{
		public int LearnerLevelStatusID { get; set; }
		public int? LearningLevelID { get; set; }
		public int? LearnerID { get; set; }
		public DateTime? PromotedOn { get; set; }
	}
}
