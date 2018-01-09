using System;
namespace Projekt
{
	public class Podsjetnik
	{
		public int Id_podsjetnika { get; }
		public string Naziv_pod { get; set; }
		public DateTime Datum { get; set; }
		enum Prioritet { Nizak = 1, Obican, Visoki }


		public Podsjetnik()
		{
		}
	}
}
