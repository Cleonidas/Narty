using Narty.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Narty.Context
{
	public class WypozyczenieContext : DbContext
	{
		public DbSet<Wypozyczenie> Wypozyczenies { get; set;}
		public DbSet<NartyWypo> NartyWypos { get; set; }
		public DbSet<Klient> Klients { get; set; }
	}
}