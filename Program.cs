using System;

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
             int valor1, valor2, valor3, pos1, pos2, pos3;

            string [] vet = Console.ReadLine().Split(' ');
            valor1 = int.Parse(vet[0]);
            valor2 = int.Parse(vet[1]);
            valor3 = int.Parse(vet[2]);

            if (valor1 < valor2 && valor1 < valor3){
                pos1 = valor1;
                if (valor2 < valor3){
                    pos2 = valor2;
                    pos3 = valor3;
                } else {
                    pos2 = valor3;
                    pos3 = valor2;
                }
            }
            else if (valor2 < valor3 ){
                pos1 = valor2;
                if (valor1 < valor3){
                    pos2 = valor1;
                    pos3 = valor3;
                } else {
                    pos2 = valor3;
                    pos3 = valor1;
                }
            }
            else {
                pos1 = valor3;
                if  ( valor1 < valor2){
                    pos2 = valor1;
                    pos3  = valor2;
                } else {
                    pos2 = valor2;
                    pos3 = valor1;
                }
            }
            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
            Console.WriteLine();
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);
        }
    }
}
