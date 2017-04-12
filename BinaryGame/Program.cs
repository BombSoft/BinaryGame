using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BinaryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //TO DO creare menu
            
            bool menu = false;
            bool play = false;
            bool run = true;
            int corretti = 0;
            int sbagliatti = 0;

            Random random = new Random();
            while (run)
            {
               
                if (!menu)
                {
                    //da inizializzare
                    System.Console.WriteLine("Gioca a binary game Y/N");
                    menu = true;
                }
                else
                {
                   
                    if (!play)
                    {
                        String sRead = System.Console.ReadLine();
                        if (sRead.Length > 0)
                        {//salva
                            if (sRead.ToUpper()[0] == 'N')
                            {
                                run = false;
                            }
                            else if(sRead.ToUpper()[0] == 'Y')
                            {
                                System.Console.WriteLine("Rispondi ai binari nel modo più veloce possibile");
                                play = true;
                            }
                        }
                        
                        
                       
                        //non sta giocando
                    }
                    else
                    {
                        //sta giocando
                        int Exp = random.Next(0,10);
                        int Ris = 1;
                        for (int i = 0; i < Exp; i++)
                        {
                            Ris *= 2;
                        }
                        System.Console.WriteLine("2^" + Exp + "\r\n");

                        String sRead = System.Console.ReadLine();
                        if (Ris.ToString() == sRead)
                        {
                            corretti++;
                            System.Console.WriteLine("GIUSTO");
                        }
                        else
                        {
                            sbagliatti++;
                            System.Console.WriteLine("SBAGLIATO" + Ris);
                        }
                    }
                    
                }

            }
            //TO DO scoprire come leggere da tastiera
        }
    }
}
//RECICLE
//switch
//switch (menu)
//{
//    case 0://menu da inizializzare
//        break;
//}

//scrivere in un file
//System.IO.StreamWriter of = new StreamWriter("tasti.txt");

//sRead += "=" + sRead[0] + "\r\n";
//System.Console.Write("=" + sRead[0] + "\n");
//of.WriteAsync(sRead);
//    of.Close();