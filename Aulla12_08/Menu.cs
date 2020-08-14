using System;
using System.Collections.Generic;
using System.Text;

namespace Aulla12_08
{
    public class Menu
    {
        Caixa c = new Caixa();
        public void MenuP()
        {
            int mp = 0;
            while (mp != 3)
            {
                Console.Clear();
                Console.Write("\tMenu Principal");
                Console.Write("\n\n1 - Menu Senha");
                Console.Write("\n2 - Menu Caixa");
                Console.Write("\n3 - Sair");
                Console.Write("\nInforme uma opcao: ");
                mp = int.Parse(Console.ReadLine());

                switch (mp)
                {
                    case 1:
                        MenuS();
                        break;
                    case 2:
                        MenuC();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void MenuS()
        {
            int ms = 0;
            while(ms != 3)
            {
                Console.Clear();
                Console.Write("\tMenu Senha");
                Console.Write("\n\n1 - Gerar senha para fila com prioridade");
                Console.Write("\n2 - Gerar senha para fila sem prioridade");
                Console.Write("\n3 - Voltar");
                Console.Write("\nInforme uma opcao: ");
                ms = int.Parse(Console.ReadLine());

                switch (ms)
                {
                    case 1:
                        Console.Clear();
                        c.SenhaP();
                        break;
                    case 2:
                        Console.Clear();
                        c.SenhaN();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        Console.ReadLine();
                        break;
                }
            }            
        }
        public void MenuC()
        {
            int ms = 0;
            while (ms != 3)
            {
                Console.Clear();
                Console.Write("\tMenu Senha");
                Console.Write("\n\n1 - Caixa Prioritario");
                Console.Write("\n2 - Caixa Normal");
                Console.Write("\n3 - Voltar");
                Console.Write("\nInforme uma opcao: ");
                ms = int.Parse(Console.ReadLine());

                switch (ms)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\tCaixa 01 Preferencial");
                        c.CaixaP();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\tCaixa 02");
                        c.CaixaN();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
