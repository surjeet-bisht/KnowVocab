using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class VocabWordModel : Base
	{
		public int VocabWordID { get; set; }
		public int? ArticleID { get; set; }
		public string? WordTitle { get; set; }
		public string? WordMeaning { get; set; }
		public string? WordMeaning1 { get; set; }
		public string? WordMeaning2 { get; set; }
		public string? Pronunciation { get; set; }
		public int? EnglishLevelID { get; set; }
		public bool? IsIdiom { get; set; }
	}
}
