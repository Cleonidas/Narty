using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Narty.Models
{
	public class Klient
	{
		public int KlientId { get; set;}
		public string Name { get; set; }
		public int Number { get; set; }
		public List<Wypozyczenie> Wypozyczenia { get; set; }
	}
}