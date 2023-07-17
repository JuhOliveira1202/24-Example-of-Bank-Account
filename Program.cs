using Exercício;
using System;

class Program
{
    public static void Main(string[] args)
    {
        //AULA 4 - CONTA
        Console.WriteLine("----- Conta Corrente -----");

        Conta c1 = new Conta();
        //Console.WriteLine(c1.ToString());

        c1.setTitular("Ana");
        c1.depositar(50);

        if (c1.depositar(-50))
        {
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("Not Ok");
        }
        Console.WriteLine(c1.ToString());

        Conta c2 = new Conta();
        c2.setTitular("Rui");
        c1.transf(10,c2);
        Console.WriteLine(c1.ToString());
        Console.WriteLine(c2.ToString());
    }
}
