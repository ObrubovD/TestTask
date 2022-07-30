using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public abstract class Shape
	{
		public string Figure { get; set; }

		public Shape(string figure)
		{
			Figure = figure;
		}

		public abstract double Square();

		public override string ToString()
		{
			return $"Фигура: " + Figure;
		}
	}
}
