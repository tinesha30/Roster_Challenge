using System;
namespace Backend.DTO
{
	public class NewRateCommand
	{
		
		public NewRateCommand()
		{
		}

		//prperties
		public int ArtistId { get; set; }
		public double Amount { get; set; }
	}
}

