using System;
namespace Projekt
{
	public class Stol
	{
		int id_stola;
		string naziv_stola;
		int broj_stolica;
		public Stol()
		{
			
		}
		public Stol(string naziv_st,int broj_st)
		{
			naziv_stola = naziv_st;
			broj_stolica = broj_st;
		}

		public int Id_stola
		{
			get
			{
				return id_stola;
			}
		}
		public string Naziv_stola
		{
			get
			{
				return naziv_stola;
			}
			set
			{
				naziv_stola = value;
			}
		}
		public int Broj_stolica
		{
			get
			{
				return broj_stolica;
			}
			set 
			{
				broj_stolica = value;
			}

		}

	}
}
