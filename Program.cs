using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personnummer;
            while (true)
            {
                Console.WriteLine("Skriv in ditt personnummer 'YYMMDDXXXX': ");
                personnummer = Console.ReadLine().ToString();
                validator(personnummer);
                
            static void validator (string value) 
            {
                List<char> chars = new List<char>();
                chars.AddRange(value);
                foreach (char c in chars)
                {

                    if (c == '-' || c == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning, personnummer får endast innehålla siffror!");
                        break;
                    }

                }
                if (!value.All(char.IsDigit))
                {
                    Console.WriteLine("Felaktig inmatning, personnummer får endast innehålla siffror!");
                }
                else if (value == " ")
                {
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatning, du måste skriva något till konsolen!");
                }
                else if (value.Length != 10)
                {
                    Console.Clear();
                    Console.WriteLine("Felaktig inmatning, måste innehålla 10 siffror");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Korrekt inamtning");
                }


            }
            static void uträkningKontrollsiffra(List<char> value)
            {
                int sum;
                int index;
                List<int> indexLista = new List<int>();
              
                
                for (int i = 0; i < value.Count;)
                {
                    if(i == 0) 
                    {
                        index = value[i] * 2;
                        indexLista.Add(index);
                    }
                    else if(i % 2 == 0)
                    {
                        index = value[i] * 2;
                        indexLista.Add(index);
                    }
                    else
                    {
                        index = value[i];
                        indexLista.Add(index);
                    }

                    if (value[i] == 10)
                    {
                        index = 1;
                        indexLista.Add(index);
                    }
                    else if (value[i] > 10)
                    {
                        index = (value[i] - 10);
                        indexLista.Add(index);
                    }

                }
                foreach(int i in indexLista)
                {
                    sum =+ i;
                }

                
            }

            }
        }
    }
}