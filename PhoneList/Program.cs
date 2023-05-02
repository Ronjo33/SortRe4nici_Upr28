using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneList = new SortedDictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "A")
                {
                    string name = command[1];
                    string phone = command[2];
                    phoneList[name] = phone;
                }
                else  if (command[0] == "S")
                {
                    string name = command[1];
                    if (phoneList.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneList[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contakta  {name} go nqma.");
                    }
                }
                if (command[0] == "ListAll")
                {

                    Console.WriteLine("Contact:");
                    foreach (KeyValuePair<string, string> entry in phoneList)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
                else if (command[0] == "END")
                {
                    break;
                }
               
            }
        }
    }
}
    
 
