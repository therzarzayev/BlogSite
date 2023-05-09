﻿namespace BlogUI.ViewModels
{
	public class WriterViewModel
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public IFormFile? Image { get; set; }
		public string? Email { get; set; }
		public string? Password { get; set; }
		public bool? Status { get; set; }
	}
}
