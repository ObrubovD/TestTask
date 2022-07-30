using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Triangle : Shape
	{
		public double EdA { get; set; }
		public double EdB { get; set; }
		public double EdC { get; set; }

		public Triangle(string figure, double a, double b, double c) : base(figure)
		{
			if (isExist(a, b, c))
			{
				EdA = a;
				EdB = b;
				EdC = c;
			}
		}

		public override double Square()
		{
			var p = (EdA + EdB + EdC) / 2;
			var result = Math.Sqrt(p * (p - EdA) * (p - EdB) * (p - EdC));
			return result;
		}

		private bool isExist(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0)
			{
				throw new TriangleException("Треугольник со сторонами >0 не существует");
			}

			if (a > (b + c) || b > (a + c) || c > (a + b))
			{
				throw new TriangleException("треугольник где сторона больше суммы двух других не может существовать");
			}

			return true;
		}

		public bool isStraightTriangle()
		{
			bool isStraight = (EdA == Math.Sqrt(Math.Pow(EdB, 2) + Math.Pow(EdC, 2))
							   || EdB == Math.Sqrt(Math.Pow(EdA, 2) + Math.Pow(EdC, 2))
							   || EdC == Math.Sqrt(Math.Pow(EdA, 2) + Math.Pow(EdB, 2)));

			return isStraight;
		}
	}
}
