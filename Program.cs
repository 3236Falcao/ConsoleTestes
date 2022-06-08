using System;

namespace ConsoleTestes
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            //IniciarSeletor();
        }

        public void IniciarSeletor()
        {
            string[] nomeVar = new string[4];            

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Insira uma fruta ");
                }
                else
                {
                    Console.WriteLine("Insira outra fruta ");
                }

                nomeVar[i] = Console.ReadLine();
                Console.WriteLine("A fruta " + (i + 1) + " é " + nomeVar[i]);
                Console.Clear();
            }
            Console.WriteLine("As frutas inseridas foram " + nomeVar);
        }
    }
                    
}
