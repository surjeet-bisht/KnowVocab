using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class Base
	{
		public System.DateTime LastUpdated { get; set; }
		public string? UpdatedBy { get; set; }
		public bool Active { get; set; }
	}
}
