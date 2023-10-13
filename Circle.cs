using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_5___Circles
{
	internal class Circle
	{
		public double area { get; set; }
		public double radius { get; set; }
		public Circle(double radius)
		{
			this.radius = radius;
			area = GetArea(radius);
		}

		public double GetArea(double radius)
		{
			double area = radius * radius * Math.PI;

			return area;
		}
	}
}
