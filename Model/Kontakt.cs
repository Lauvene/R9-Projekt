using System;
namespace Projekt
{
	public class Kontakt: Osoba
	{
		int telefon;
		enum vrsta { Mobitel = 1, Fiksni }
		enum tipusluge { Odjeca = 1, Obuca, Dekoracija, Fotografija_video, Muzika, Hrana_Pice, Restoran, Obred, Uljepsavanje, Nakit, Gost, Ostalo }


		public Kontakt()
		{
		}
	}
}
