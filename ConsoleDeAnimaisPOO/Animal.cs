﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDeAnimaisPOO
{
	internal class Animal
	{
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}
			
		private string tipo;

		public string Tipo
		{ //valores definidos pelo dev. - Cachorro - Gato - Peixe
			get { return tipo; }
			set
			{
				if (value == "Cachorro" || value == "Gato" || value == "Peixe")
				{
					tipo = value;

				}
				else
				{
					tipo = "Peixe";
				}
			}
		}
	}
}
