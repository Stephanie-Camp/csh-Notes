using System;

namespace Bank {
    class Program {
        static void Main(string[] args) {

            BankATM newAccount = new BankATM();

            while (true) {

                Console.Write("\n   -  W E L C O M E  -\n    Do you need help?\n    | 1 - Login.\n    | 2 - Create a account.\n    | 0 - Exit the program.\n\n > Select your option: ");
                switch (int.Parse(Console.ReadLine())) {
                    case 1:

                        Console.WriteLine("\n Hi! You are try login?");
                        Console.Write(" > Inform your number Account: ");
                        string accLogin = Console.ReadLine();
                        Console.Write(" > Inform your agency: ");
                        string agLogin = Console.ReadLine();
                        
                        newAccount.LoginAcc([accLogin, agLogin]);

                    break;
                    case 2:

                        Console.WriteLine("\n Welcome! We need confirm some datas before: ");
                        Console.Write(" | Inform your name: ");
                        string newName = Console.ReadLine();

                        Console.Write(" | Inform your CPF: ");
                        ulong newCpf = ulong.Parse(Console.ReadLine());
                        if ((newCpf.ToString()).Length != 11) 
                            Console.Write("\n Invalid CPF. \n Try again. \n");

                        if (!((newCpf.ToString()).Length != 11))
                            newAccount.CreateAccount([newName, newCpf.ToString()]);
                        
                    break;
                    case 0:

                        Console.WriteLine("\n You logout.");
                        System.Environment.Exit(0);

                    break;
                    default:
                        Console.WriteLine("\n It's a invalid option! Try again. \n");
                    break;
                }

            }

        }
    }
}