using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWithFun.Data.Models
{
	public class ArticleModel:Base
	{
		public int ArticleID { get; set; }
		public int? CategoryID { get; set; }
		public int? EnglishLevelID { get; set; }
		public string? ArticleShortTitle { get; set; }
		public string? ArticleSeoTitle { get; set; }
		public string? ThumbnailURL { get; set; }
		public string? ArticleTitle { get; set; }
		public string? ArticleDescription { get; set; }
		public string? ArticleSource { get; set; }
		public string? ArticleSourceURL { get; set; }
		public string? ArticleAuthor { get; set; }
		public string? PublishedBy { get; set; }
		public DateTime? PublishedOn { get; set; }
		public int? ArticleStatus { get; set; }
		public bool? IsThirdParty { get; set; }
		public int? ArticleViews { get; set; }
	}
}
