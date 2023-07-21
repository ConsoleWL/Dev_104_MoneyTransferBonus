using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        Person me;
        Person person1;
        Person person3;
        Person person4;
        Person person5;
        Person person6;
        public Simulation()
        {
             me = new Person("Nikki", 1000);
             person1 = new Person("Nevin", 1000000);
             person3 = new Person("Amy", 1000);
             person4 = new Person("Kyle", 1000);
             person5 = new Person("Jaron", 1000);
             person6 = new Person("Steve", 1000);
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.

            Console.WriteLine();
            me.DisplayInfo();
            person1.DisplayInfo();
            person3.DisplayInfo();
            person4.DisplayInfo();
            person5.DisplayInfo();
            person6.DisplayInfo();
            Console.WriteLine();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!
            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            Console.WriteLine("Choose an account you want to transfer money to");
            Console.WriteLine($"For person: {person1.name}");
            Console.WriteLine($"For person: {person3.name}");
            Console.WriteLine($"For person: {person4.name}");
            Console.WriteLine($"For person: {person5.name}");
            Console.WriteLine($"For person: {person6.name}");

            string moneyToTransfer = ValidateUserInputName();
            int amountToTransfer = ValidationUserInputAmount();

            switch (moneyToTransfer)
            {
                case "Nevin":
                    me.TransferMoney(person1, amountToTransfer);
                    break;
                case "Amy":
                    me.TransferMoney(person3, amountToTransfer);
                    break;
                case "Kyle":
                    me.TransferMoney(person4, amountToTransfer);
                    break;
                case "Jaron":
                    me.TransferMoney(person5, amountToTransfer);
                    break;
                case "Steve":
                    me.TransferMoney(person6, amountToTransfer);
                    break;
                default:
                    break;
            }

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            Console.WriteLine();
            me.DisplayInfo();
            person1.DisplayInfo();
            person3.DisplayInfo();
            person4.DisplayInfo();
            person5.DisplayInfo();
            person6.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Simulation complete.");
        }

        private string ValidateUserInputName()
        {
            string transferMoneyTo;
    
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Write a name you want to transfer money to:");
                transferMoneyTo = Console.ReadLine();
                if (transferMoneyTo == person1.name || transferMoneyTo == person3.name || transferMoneyTo == person4.name || transferMoneyTo == person5.name || transferMoneyTo == person6.name)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong name, try again please");
                }
            }
            return transferMoneyTo;

        }

        private int ValidationUserInputAmount()
        {
            int amountToTransfer;
            while (true)
            {
                try
                {
                    Console.WriteLine("Write an amount");
                    amountToTransfer = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input must be a number, try again:");
                    Console.WriteLine();
                };
            }

            return amountToTransfer;
        }
    }
}
