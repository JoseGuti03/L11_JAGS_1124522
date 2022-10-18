using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_JAGS_1124522
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, libras, yen, canteurosl, canteurosd, canteurosy;

            Console.WriteLine("Ingrese la cantidad deseada en libras");
            libras = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad deseada en dolares");
            dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad deseada en yenes");
            yen = double.Parse(Console.ReadLine());

            canteurosl = libras * 1.22;
            canteurosd = dolar * 0.75;
            canteurosy = yen * 0.009;

            Console.WriteLine("El tipo de cambio de libras a euros es: {0}", canteurosl);
            Console.ReadLine();
            Console.WriteLine("El tipo de cambio dolar a euros es: {0}", canteurosd);
            Console.ReadLine();
            Console.WriteLine("El tipo de cambio de yenes a euros es: {0}", canteurosy);
            Console.ReadLine();
            Console.ReadKey();



        }
    }
}
