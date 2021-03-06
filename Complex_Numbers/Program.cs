using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(3, 2);
            Complex b = new Complex(2, 1);
            Complex c;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            c = a + b;
            Console.WriteLine("a + b = {0}", c);

            c = a - b;
            Console.WriteLine("a - b = {0}", c);

            c = a * b;
            Console.WriteLine("a * b = {0}", c);

            Console.Write("Give the power value: ");
            int power = int.Parse(Console.ReadLine());
            c = a ^ power;
            Console.WriteLine("a ^ {0} = {1}", power, c);

            a.Trigonometric_Form();

            Console.ReadKey();
        }
    }

    internal class Complex
    {
        private int real;
        private int imaginary;

        public Complex() : this(0)
        {
        }

        public Complex(int real_part)
        {
            real = real_part;
            imaginary = 0;
        }

        public Complex(int real_part, int imaginary_part)
        {
            real = real_part;
            imaginary = imaginary_part;
        }

        public static Complex operator +(Complex c) => c;
        public static Complex operator -(Complex c) => new Complex(-c.real, -c.imaginary);

        public static Complex operator +(Complex a, Complex b)
            => new Complex(a.real + b.real, a.imaginary + b.imaginary);

        public static Complex operator -(Complex a, Complex b) => a + (-b);

        public static Complex operator *(Complex a, Complex b)
            => new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + a.imaginary * b.real);

        public static Complex operator ^(Complex a, int b)
        {
            Complex x = a;

            for (int i = 2; i <= b; i++)

                x *= a;

            return x;
        }

        public void Trigonometric_Form()
        {
            double r = Math.Sqrt(real * real + imaginary * imaginary);
            double teta = Math.Atan(imaginary / real);

            Console.WriteLine("Trigonometric form of the complex number is {0} * ({1} + i * {2})", r, Math.Cos(teta), Math.Sin(teta));
        }

        public override string ToString() => $"{real} + {imaginary} * i";
    }
}
