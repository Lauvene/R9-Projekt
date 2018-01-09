using System;
namespace Projekt
{
	public class Osoba
	{
		private string ime;
		private string prezime;
		private string email;

		public Osoba()
		{
		}
		public string Ime
		{
			get
			{
				return ime;
			}
			set
			{
				ime = value;
			}
		}
		public string Prezime
		{
			get
			{
				return prezime;
			}
			set
			{
				prezime = value;
			}
		}
		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}
	}
}
