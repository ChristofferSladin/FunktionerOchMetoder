using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FunktionerOchMetoder.MoneyLaundry
{
    public class MoneyLaundryJob
    {
        public void Run()
        {
            // c:\Transactions

            Directory.CreateDirectory("c:\\transactions");

            foreach (var filePath in Directory.GetFiles("c:\\transactions", "*.txt"))
            {
                var fileName = Path.GetFileName(filePath);
                Console.WriteLine(fileName);

                if (fileName.StartsWith("deposit"))
                {
                    Console.WriteLine("Hittat en insättning ");
                }
                if (fileName.StartsWith("withdrawal"))
                {
                    Console.WriteLine("Hittat uttag ");
                }

                var fileInfo = new FileInfo(filePath);
                Console.WriteLine($"{fileName} is {fileInfo.Length} bytes");    
                // här körs algoritm för att hitta eventuella pengatvätt transaktioner

                File.Delete(filePath);

            }

        }
    }
}
