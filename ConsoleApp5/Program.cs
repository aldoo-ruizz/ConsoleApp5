using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
          
        static void Main(string[] args)
        {
            acciones acciones = new acciones();
            while (true)
            {

                switch (menu())
                {
                    case 1:
                        Console.WriteLine("Dame los numeros a sumar");
                        int a=int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.sumar(a,b));
                    break;

                    case 2:
                        Console.WriteLine("Dame los numeros a restar");
                        int n1 = int.Parse(Console.ReadLine());
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.restar(n1, n2));
                        break;

                    case 3:
                        Console.WriteLine("Dame los numeros a multiplicar");
                        int m1 = int.Parse(Console.ReadLine());
                        int m2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.multi(m1, m2));
                        break;

                    case 4:
                        Console.WriteLine("Dame los numeros a dividir");
                        int d1 = int.Parse(Console.ReadLine());
                        int d2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("El resultado es: " + acciones.dividir(d1, d2));
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static int menu()
        {
            int opc;
            Console.WriteLine("1)Sumar");
            Console.WriteLine("2)Restar");
            Console.WriteLine("3)Multiplicar");
            Console.WriteLine("4)Dividir");
            Console.WriteLine("5)salir");
            opc=int.Parse(Console.ReadLine());
            return opc; 




        }

    }
}
