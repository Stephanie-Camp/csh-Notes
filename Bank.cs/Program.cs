using System;

namespace Bank {
    class Program {
        static void Main(string[] args) {
            BankATM newAccount = new BankATM();
            while (true) {

                Console.Write("\n   -  W E L C O M E  -\n    Do you need help?\n    | 1 - Login.\n    | 2 - Create a account.\n    | 0 - Exit the program.\n\n > Select your option: ");
                switch(int.Parse(Console.ReadLine())) {
                    case 1:
                        Console.WriteLine("\n Hi! You are try login?");

                        List<string> loginAcc = new List<string>();
                        Console.Write(" > Inform your number Account: ");
                        loginAcc.Add(Console.ReadLine()); 
                        Console.Write(" > Inform your agency: ");
                        loginAcc.Add(Console.ReadLine()); 
                        
                        Console.Write(" > Informe your password: ");
                        EncryptPass pass = new EncryptPass();
                        loginAcc.Add(pass.GetPassword()); 
                        
                        Console.WriteLine(newAccount.LoginAcc(loginAcc));
                    break;
                    case 2:
                        Console.WriteLine("\n Welcome! We need confirm some datas before: ");

                        newAccount.CreateAccount();
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