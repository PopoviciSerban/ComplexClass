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

        public static Complex operator +(Complex a, Complex b) => a + b;

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

        public void Trigonometric_Form(Complex a)
        {
            double r = Math.Sqrt(a.real * a.real + a.imaginary * a.imaginary);
            double teta = Math.Atan(a.imaginary / a.real);

            Console.WriteLine("Trigonometric form of the complex number is {0} * ({1} + i * {2})", r, Math.Cos(teta), Math.Sin(teta));
        }

    }
}
