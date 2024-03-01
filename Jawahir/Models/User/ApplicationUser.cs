using Jawahir.Models.MarketModel;
using Microsoft.AspNetCore.Identity;

namespace Jawahir.Models.User
{
	public class ApplicationUser : IdentityUser
	{
		public string AccountUsername { get; set; }
		public string? UserImage { get; set; }
		public DateTime Dob {  get; set; }
		public float Rating { get; set; }
		public int RatingCount { get; set; } = 0;
		public string? Country {  get; set; }
		public string? City { get; set; }
		public string? Street { get; set; }
		public Market? Market { get; set; }
	}
}
