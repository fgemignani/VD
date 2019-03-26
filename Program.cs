using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double  Num01, Num02, Result;
            string  Verify, Oper;

            Console.Clear(); 
            
            PriNum:
                Console.WriteLine("Digite O Primeiro Numero:");
                Verify = Console.ReadLine();
                if (Double.TryParse(Verify, out Num01))
                {
                    Num01 = double.Parse(Verify);
                }
                else
                
                {
                    Console.Clear();
                    Console.WriteLine("Voce não digitou um número válido! Digite Novamente! ");
                    Console.WriteLine("");
                    goto PriNum;
                }

            SecNum:
                Console.WriteLine("Digite O Segundo Numero:");
                Verify = Console.ReadLine();
                if (Double.TryParse(Verify, out Num02))
                {
                    Num02 = double.Parse(Verify);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Voce não digitou um número válido! Digite Novamente! ");
                    Console.WriteLine("");
                    Console.WriteLine("Primeiro Numero: " + Num01);
                    Console.WriteLine("");
                    goto SecNum;
                }

            Operacao:
               
                Console.WriteLine("Digite a Operação Desejada:");
                Console.WriteLine("  - A para Adição");
                Console.WriteLine("  - S para Subtração");
                Console.WriteLine("  - D para Divisão");
                Console.WriteLine("  - M para Multiplicação");
                Oper =  Console.ReadLine();
                
                if (Oper.ToLower() == "a" | Oper.ToLower() == "s" | Oper.ToLower() == "d" | Oper.ToLower() == "m")
                {
                
                    if (Oper.ToLower() == "a")
                    {  
                        Result = Num01 + Num02;
                        Console.WriteLine("Resultado da Adição: " + Result);
                    }
                    if (Oper.ToLower() == "s")
                    {
                        Result = Num01 - Num02;
                        Console.WriteLine("Resultado da Subtração: " + Result);
                    }
                    if (Oper.ToLower() == "d" & Num02 == 0)
                    {
                        Console.WriteLine("Não Existe Divisão por 0 (Zero)!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite um Segundo Numero Diferente de Zero!");
                        goto SecNum;
                    }             
                    if (Oper.ToLower() == "d" & Num02 != 0)
                    {
                        Result = Num01 / Num02;
                        Console.WriteLine("Resultado da Divisão: " + Result);
                    }
                    if (Oper.ToLower() == "m")
                    {
                        Result = Num01 * Num02;
                        Console.WriteLine("Resultado da Multiplicação: " + Result);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Não foi digitada uma escolha válida. Vamos recomeçar?");
                    Console.WriteLine("");
                    Console.WriteLine("Primeiro Numero: " + Num01 + " | Segundo Numero: " + Num02);
                    Console.WriteLine("");
                    goto Operacao;
                }
        }
    }
}
