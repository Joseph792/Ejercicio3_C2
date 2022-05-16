// See https://aka.ms/new-console-template for more information
            double grados, radianes;
            const double pi = 3.1416;
            
            Console.Write("Introduzca la cantidad de grados a convertir: ");
            grados = double.Parse(Console.ReadLine());

            radianes = (grados * pi) / 180;

            Console.WriteLine("El resultado en radianes es: {0}", radianes);