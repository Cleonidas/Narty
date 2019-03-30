using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Narty.Models
{
	public class Wypozyczenie
	{
		public int WypozyczeniaId { get; set; }
		public int Cena { get; set; }
		public DateTime DataWypozyczenia { get; set; }
		public DateTime DataZwrotu { get; set; }							  
		public virtual List<NartyWypo> NartyWypos{ get; set; }

	}
}