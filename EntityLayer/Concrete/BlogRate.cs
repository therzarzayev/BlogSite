
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class BlogRate
	{
		[Key]
		public int Id { get; set; }
		public int? BlogId { get; set; }
		public float? TotalRate { get; set; }
		public int? TotalRateCount { get; set; }
	}
}
