using System;

namespace classwork3
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("If you want to calculate square press 1, for circle press 2" );
			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 1)
			{
				Console.Write("Enter length: ");

				int lenght = Convert.ToInt32(Console.ReadLine());

				Square(lenght);

			}
			else if (choice == 2)
			{
				Console.Write("Enter Radius: ");

				int Radius = Convert.ToInt32(Console.ReadLine());

				Circle(Radius);
			}

			//double Area = Math.PI * Radius * Radius;
			//Console.WriteLine("Area of circle: " + Area);

			Console.ReadLine();
		}


		static void Square (int length)
	    {

		    //Console.Write("Enter the side of square: ");
			//int Side = Convert.ToInt32(Console.ReadLine());
		    int Area = length * length;
			Console.WriteLine("Area of Square: " + Area);


		}

		static void Circle(int radius)
		{
		 double Area = Math.PI * radius * radius;
		 Console.WriteLine("Area of circle: " + Area);
		}

    



			
	}
}
