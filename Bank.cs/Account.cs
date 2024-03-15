namespace Bank {
    class Account {

        private List<string[]> clientList = new List<string[]>() {};
        private string[] myDt = new string[] {};
        private int myStatement = 0;

        public Account(List<string[]> datas, string[] dtCli) { //construtor da classe
            clientList = datas;
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
                    Transfer();
                if (opc == 0)
                    break;
            }
        }

        private void Withdrawal() { //myDt - meus dados  myStatement - meu dinheiro clientList - BD
            if (myStatement < 1) {
                Console.WriteLine("\n Invalid.");
            } else {
                Console.Write("\n Write how much you wanna withdraw: ");
                int value = int.Parse(Console.ReadLine());
                
                if (ConfirmTransation() == true && value > 0)
                    myStatement = int.Parse(myDt[5]) - value;
                    myDt[5] = (myStatement).ToString();
            }

        }
        private void Deposit() {
            Console.Write("\n Write how much you wanna deposit: ");
            myStatement = int.Parse(Console.ReadLine());
            if (myStatement < 1 ) {
                Console.WriteLine("\n Invalid. ") ;

            } else {
                if (ConfirmTransation() == true)
                myStatement = int.Parse(myDt[5]) + myStatement;
                myDt[5] = (myStatement).ToString();
            }
        }
        private void Transfer() {
            if (myStatement < 1 ) {
                Console.WriteLine("\n Invalid. ") ;
            } else {

                Console.Write("Insert the account number to transfer: ");
                string accTransfer = Console.ReadLine();
                Console.Write("Insert the agency number to transfer: ");
                string agTransfer = Console.ReadLine();

                foreach (var data in clientList) {

                    if (myDt[0] == accTransfer && myDt[1] == agTransfer) {
                        Console.WriteLine("\n Account already exist");
                        break;
                    }

                    if ((data[0] == accTransfer && data[1] == agTransfer) && (myDt[0] != accTransfer && myDt[1] != agTransfer)) {
Console.WriteLine(@$"  
 ._____________________________.
 |   Account   |  {data[0]}          |
 |   Agency    |  {data[1]}          |
 |    CPF      |  {data[3]}    |
 ·-----------------------------·  
  >>>> {data[5]}");
                    Console.Write("\n Insert how mucha you wanna pass: ");
                    int value = int.Parse(Console.ReadLine()) + int.Parse(data[5]);

                    if (ConfirmTransation() == true && value > 0) {
                        myStatement = int.Parse(myDt[5]) - value;
                        myDt[5] = (myStatement).ToString();
                        data[5] = (value + int.Parse(data[5])).ToString();
                        }
                    }
                } 
            }        
        }        
        private bool ConfirmTransation() {
            Console.Write("\n You confirm? Y/n: ");
            bool confirm = ((Console.ReadLine()).ToUpper() == "Y");

            return confirm;
        }

    }
}