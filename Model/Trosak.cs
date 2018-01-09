using System;
namespace Projekt
{
	public class Trosak
	{
		public int Cijena { get; set; }
		public string Opis_troska { get; set; }
		enum tip_troska { Odjeca = 1, Obuca, Dekoracija, Fotografija_video, Muzika, Hrana_Pice, Restoran, Obred, Uljepsavanje, Nakit, Ostalo }

		public Trosak()
		{
		}
	}
}
