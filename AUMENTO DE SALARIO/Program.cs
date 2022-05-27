using System;

namespace AUMENTO_DE_SALARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SalarioAtual;
            double SalarioNovo;
            double Reajuste;
            double Percentual;

            SalarioAtual = double.Parse(Console.ReadLine());
            if (SalarioAtual <= 400){
                Percentual = 15;
            } else if (SalarioAtual <= 800){
                Percentual = 12;
            }else if (SalarioAtual <= 1200){
                Percentual = 10;
            }else if (SalarioAtual <= 2000){
                Percentual = 7;
            }else{
                Percentual = 4;
            };
            SalarioNovo = SalarioAtual + (SalarioAtual * (Percentual / 100));
            Reajuste = SalarioNovo - SalarioAtual;

            Console.WriteLine("Novo salario:" + SalarioNovo.ToString("0.00"));
            Console.WriteLine("Reajuste ganhou:" + Reajuste.ToString("0.00"));
            Console.WriteLine("Em percentual:" + Percentual.ToString("0") +"%");

        }
    }
}
