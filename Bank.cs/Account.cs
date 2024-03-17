namespace Bank {
    class Account {

        private string[] myDt = new string[] {};
        private int myStatement = 0;
        private BankATM entryTransation = new BankATM();

        public Account(string[] dtCli) { //construtor da classe
            myDt = dtCli;
            myStatement = int.Parse(myDt[5]);
            
            while (true) {

                Console.WriteLine(@$" 
 {dtCli[4]}, its your account: 
 .________________________.
 |  My Account |  {myDt[0]}  |
 |   Agency    |  {myDt[1]}  |
 ·------------------------·
 >  Statement:  R$ {myDt[5]}  ");

                Console.Write("\n > Which operation you want do?\n |1 - Withdrawal\n |2 - Deposit\n |3 - Transfer\n |0 - Exit\n\n > Insert a correspondent operation number: ");
                int opc = int.Parse(Console.ReadLine());
                
                if (opc == 1)
                    Withdrawal();
                if (opc == 2)
                    Deposit();
                if (opc == 3)
                    entryTransation.Transfer(myStatement, myDt);
                if (opc == 0)
                    break;
            }
        }

        private void Withdrawal() { //myDt - meus dados  myStatement - meu dinheiro clientList - BD
            if (myStatement < 1)
                Console.WriteLine("\n Invalid.");

            if (!(myStatement < 1))
                Console.Write("\n Write how much you wanna withdraw: ");
                int value = int.Parse(Console.ReadLine());
                
                if (value > 0 && value < myStatement)
                    myStatement = int.Parse(entryTransation.subTransation(value, myDt));

        }
        private void Deposit() {

            Console.Write("\n Write how much you wanna deposit: ");
            myStatement = int.Parse(Console.ReadLine());

            if (myStatement < 1 ) 
                Console.WriteLine("\n Invalid. ");

            if (!(myStatement < 1 ))
                myStatement = int.Parse(entryTransation.addTransation(myStatement, myDt));
        }
  
    }
}