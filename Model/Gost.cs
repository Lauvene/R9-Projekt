using System;
namespace Projekt
{
	public class Gost: Osoba
	{

	private string napomena;
	enum vrstaGosta { Mladenka_gost = 1, Mladozenja_gost, Zajednicki_gost };
	enum potvrdaDolaska { Potvrden = 1, Odbijen, Nedefiniran };

	public Gost()
	{

	}
	public string Napomena
	{
		get
		{
			return napomena;
		}
		set
		{
			napomena = value;
		}   }
	}
}
