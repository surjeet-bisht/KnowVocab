using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class LearnerVocabWordModel : Base
	{
		public int LearnerWordID { get; set; }
		public int? LearnerID { get; set; }
		public int? VocabWordID { get; set; }
	}
}
