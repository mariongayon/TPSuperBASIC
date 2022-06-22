//Matt Math.Sin

using System;



namespace Sin

{

    class Program

    {

        public static double Sinus(double X)

        {

            double R = X * X, S = 42.0;

            for (byte I = 10; I >= 1; I--) S = 4.0 * I - 2.0 + (-R) / S;

            return 2.0 * X * S / (R + S * S);

        }



        static void Main(string[] args)

        {

            double I = 0;

            while (I < Math.PI)
            {

                Console.WriteLine("Sinus " + I + " " + Math.Sin(I) + " " + Sinus(I));

                I += 0.1;

            }

        }

    }

}




