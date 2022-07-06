using System;

namespace ejercicio2DeLutien
{
    class Program
    {
        static void Main(string[] args)
        {
            double superficie, perimetro, ladoA, ladoB, ladoC, sp;
            Console.WriteLine("ingrese el valor del primer lado del triangulo");
            ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del segundo lado del triangulo");
            ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del tercer lado del triangulo");
            ladoC = double.Parse(Console.ReadLine());

            if (Math.Pow(ladoA, 2) == (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
            {
                Console.WriteLine("el triangulo que se forma es rectangulo");
                
            }
            else
            {
                if (Math.Pow(ladoA, 2) > Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
                {
                    Console.WriteLine("el triangulo que se forma es OBTUSANGULO");
                }
                else
                {
                    if (Math.Pow(ladoA, 2) < Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
                    {
                        Console.WriteLine("el triangulo que se forma es ACUTANGULO");
                    }
                }   
            }
            perimetro = (ladoA + ladoB + ladoC);
            sp = (perimetro) / 2;
            superficie = Math.Sqrt(sp * (sp - ladoA) * (sp - ladoB) * (sp - ladoC) / 2);
            Console.WriteLine($"el perimetro de su triangulo es igual a: {perimetro}");
            Console.WriteLine($"la superficie de su triangulo es igual a: {superficie}");
        }
         
    }
}
