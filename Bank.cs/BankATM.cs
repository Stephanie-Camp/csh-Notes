namespace Bank {
    class BankATM {

        private string Cpf;
        private string Name;
        private string Agency;
        private string CurrentAcc;

        private List<string[]> DataList = new List<string[]>() {};
        
        public BankATM () {}

        public void CreateAccount() {

            Console.Write(" | Inform your name: ");
            Name = Console.ReadLine();
            Console.Write(" | Inform your CPF: ");
            Cpf = Console.ReadLine();
            Console.Write((Cpf.Length != 11) ? "\n Invalid CPF. \n Try again. \n" : "");
            CurrentAcc = numberAcc();
            Agency = numberAcc();

            Console.Write(" | Create a password of 8 characters: ");
            EncryptPass Pass = new EncryptPass();
            
            if (!(Pass.GetPassword() == "0")) { 
                DataList.Add([CurrentAcc, Agency, Pass.GetPassword(), Cpf, Name, "0"]);
                Console.WriteLine(AccountData());
            }else { 
                Console.WriteLine("\nInvalid password. \n Try Again.");
            }
        }
        public string LoginAcc(List<string> tryLogin) {
            foreach (var data in DataList) {
                
                if (data.Contains(tryLogin[0]) && data.Contains(tryLogin[1]) && data.Contains(tryLogin[2])) {
                    Account addData = new Account(DataList, data);
                    return " >>>> You logged. <<<<"; // Termina a função após encontrar um login válido
            }

        }
            return  "Login inválido";
        }
        private string AccountData() {
            return (@$"  >> Your account is open! 
  ._____________________________.
 |  Account Number  |  {CurrentAcc}  |
 |  Agency Number   |  {Agency}  |
 ·-----------------------------·");
        }
        public string numberAcc() {
            Random rnd = new Random();
            int[] number = new int[6];

            for (int i = 0; i < 6; i++) {
                number[i] = (rnd.Next(0, 9));
            }
            return String.Join("", number);
        }

    }
}