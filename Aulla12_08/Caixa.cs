using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Aulla12_08
{
    public class Caixa
    {
        Queue senhaP;
        Queue senhaN;
        int contSP = 1;
        int contSN = 1;
        int Preferencial = 0;
        int Normal = 0;
        public void SenhaP()
        {
            if(senhaP == null)
            {
                senhaP = new Queue();
            }
            if(contSP < 10)
            {
                senhaP.Enqueue("CXP - 00" + contSP);
                Console.WriteLine($"Sua senha: CXP - 00{contSP}");
                contSP++;
                Preferencial++;
            }
            else
            {
                senhaP.Enqueue("CXP - 0" + contSP);
                Console.WriteLine($"Sua senha: CXP - 0{contSP}");
                contSP++;
                Preferencial++;
            }

            Console.WriteLine($"\nProxima senha no Caixa Preferencial: {senhaP.Peek()}");
            Console.ReadLine();
            
        }

        public void SenhaN()
        {
            if (senhaN == null)
            {
                senhaN = new Queue();
            }
            if (contSN < 10)
            {
                senhaN.Enqueue("CXN - 00" + contSN);
                Console.WriteLine($"Sua senha: CXN - 00{contSN}");                
                contSN++;
                Normal++;
            }
            else
            {
                senhaN.Enqueue("CXN - 0" + contSN);
                Console.WriteLine($"Sua senha: CXN - 0{contSN}");
                contSN++;
                Normal++;
            }
            if(Preferencial > 0)
            {
                Console.WriteLine($"\nProxima senha no caixa: {senhaP.Peek()}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\nProxima senha no caixa: {senhaN.Peek()}");
                Console.ReadLine();
            }
            

            
        }

        public void CaixaP()
        {
            
            if (Preferencial > 0)
            {
                Console.WriteLine($"Senha: {senhaP.Dequeue()}");
                Preferencial--;
                if(Preferencial > 0)
                {
                    Console.WriteLine($"\nProxima senha no caixa: {senhaP.Peek()}");
                    Console.ReadLine();
                }
                else
                {
                    if (Normal > 0)
                    {
                        Console.WriteLine($"\nProxima senha no caixa: {senhaN.Peek()}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Nao tem niguem em espera");
                        Console.ReadLine();
                    }
                }                
            }
            else
            {
                if (Normal > 0)
                {
                    Console.WriteLine($"Senha: {senhaN.Dequeue()}");
                    Console.ReadLine();
                    Normal--;
                    if(Normal > 0)
                    {
                        Console.WriteLine($"\nProxima senha no caixa: {senhaN.Peek()}");
                    }
                    else
                    {
                        Console.WriteLine("Nao tem niguem em espera");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Nao tem niguem em espera");
                    Console.ReadLine();
                }
            }
            
        }

        public void CaixaN()
        {

            if (Normal > 0)
            {
                Console.WriteLine($"Senha: {senhaN.Dequeue()}");
                Normal--;
                if (Normal > 0)
                {
                    Console.WriteLine($"\nProxima senha no caixa: {senhaN.Peek()}");
                    Console.ReadLine();
                }
                else
                {
                    if (Preferencial > 0)
                    {
                        Console.WriteLine($"\nProxima senha no caixa: {senhaP.Peek()}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Nao tem niguem em espera");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                if (Preferencial > 0)
                {
                    Console.WriteLine($"Senha Preferencial: {senhaP.Dequeue()}");                    
                    Preferencial--;
                    if (Preferencial > 0)
                    {
                        Console.WriteLine($"\nProxima senha no caixa: {senhaP.Peek()}");
                    }
                    else
                    {
                        Console.WriteLine("Nao tem niguem em espera");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Nao tem niguem em espera");
                    Console.ReadLine();
                }
            }

        }
    }
}
