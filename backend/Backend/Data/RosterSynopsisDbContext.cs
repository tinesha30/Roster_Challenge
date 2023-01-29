using System;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
	public class RosterSynopsisDbContext:DbContext
	{
		
		public RosterSynopsisDbContext(DbContextOptions<RosterSynopsisDbContext> options)
			: base(options)  
		{
			
		}
		public DbSet<Artist> Artists { get; set; }
		public DbSet<Rate> Rates { get; set; }
	}
}

