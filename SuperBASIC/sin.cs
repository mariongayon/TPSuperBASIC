//Matt Math.Sin



using System;



class Sin
{



   


#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
    public static void Main(String[] arg)
#pragma warning restore IDE0060 // Supprimer le paramètre inutilisé
=======
    public static void Main(String[]
>>>>>>> c9f5823f332b25f02801097b45ab75270b292877

    {

        double a = 30;



        // converting value to radians

        double b = (a * (Math.PI)) / 180;



        // using method and displaying result

        Console.WriteLine(Math.Sin(b));

        a = 45;



        // converting value to radians

        b = (a * (Math.PI)) / 180;



        // using method and displaying result

        Console.WriteLine(Math.Sin(b));

        a = 60;



        // converting value to radians

        b = (a * (Math.PI)) / 180;



        // using method and displaying result

        Console.WriteLine(Math.Sin(b));

        a = 90;



        // converting value to radians

        b = (a * (Math.PI)) / 180;



        // using method and displaying result

        Console.WriteLine(Math.Sin(b));

    }

}




