using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class LearningLevelModel : Base
	{
		public int LearningLevelID { get; set; }
		public string? LevelName { get; set; }
		public int? LevelOrder { get; set; }
		public int? DaysStreak { get; set; }
		public int? NoOfArticles { get; set; }
	}
}
