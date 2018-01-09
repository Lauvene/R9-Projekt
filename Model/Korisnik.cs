using System;
namespace Projekt
{
	public class Korisnik : Osoba
	{
		private DateTime datum_vjencanja;
		private int budzet;
		private int broj_gostiju;

		public Korisnik()
		{

		}

		public DateTime Datum_vjencanja
		{
			get
			{
				return datum_vjencanja;
			}
			set
			{
				datum_vjencanja = value;
			}
		}
		public int Budzet
		{
			get
			{
				return budzet;
			}
			set
			{
				budzet = value;
			}
		}
		public int Broj_gostiju
		{
			get
			{
				return broj_gostiju;
			}
			set
			{
				broj_gostiju = value;
			}
		}
	}
}
