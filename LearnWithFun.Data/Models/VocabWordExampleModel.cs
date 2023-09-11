using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class VocabWordExampleModel : Base
	{
		public int VocabWordExampleID { get; set; }
		public int? VocabWordID { get; set; }
		public string? Example { get; set; }
		public string? ExampleHindi { get; set; }
	}
}
