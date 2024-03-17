namespace Bank {
    class BankATM {

        private string Cpf;
        private string Name;
        private string Agency;
        private string CurrentAcc;
        private string Pass;
        static private List<string[]> DataList = new List<string[]> ();
        private Account addData;
        EncryptPass pass;
        
        public BankATM () {}

        public void CreateAccount(string[] dataCreated) {
            Name = dataCreated[0];
            Cpf = dataCreated[1];
            CurrentAcc = numberAcc();
            Agency = numberAcc();
            Console.Write(" | Create a password of 8 characters: ");
            pass = new EncryptPass(Console.ReadLine());
            
            if (!(pass.GetPassword() == "0"))
                DataList.Add([CurrentAcc, Agency, pass.GetPassword(), Cpf, Name, "0"]);
                Console.WriteLine(AccountData());
                Console.Write(ret());

            if (pass.GetPassword() == "0")
                Console.WriteLine("\n Invalid password. \n Try Again.");
        }
        public string LoginAcc(string[] tryLogin) {
            foreach (var data in DataList) {
                
                if (data.Contains(tryLogin[0]) && data.Contains(tryLogin[1])) {

                    Console.Write(" > Informe your password: ");
                    pass = new EncryptPass(Console.ReadLine());

                    if(data.Contains(pass.GetPassword()))
                        addData = new Account(data);
                        return " >>>> You logged. <<<<";
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
        private string numberAcc() {
            Random rnd = new Random();
            int[] number = new int[6];

            for (int i = 0; i < 6; i++) {
                number[i] = (rnd.Next(0, 9));
            }
            return String.Join("", number);
        }
        public int ret(){
            return DataList.Count;
        }
        public void Transfer(int amountAtt, string[] myDt) {

            if (amountAtt < 1 )
                Console.Write("\n Invalid.");

            if (!(amountAtt < 1 )){
                Console.Write("Insert the account number to transfer: ");
                string accTransfer = Console.ReadLine();
                Console.Write("Insert the agency number to transfer: ");
                string agTransfer = Console.ReadLine();
                
                foreach (var data in DataList) {

                    if (myDt[0] == accTransfer && myDt[1] == agTransfer){
                        Console.WriteLine("\n Account already exist");
                        break;
}
                        if ((data[0] == accTransfer && data[1] == agTransfer) && (myDt[0] != accTransfer && myDt[1] != agTransfer)){
                            Console.WriteLine(@$"  
        ._____________________________.
        |   Account   |  {data[0]}          |
        |   Agency    |  {data[1]}          |
        |    CPF      |  {data[3]}    |
        ·-----------------------------·  
        >>>> {data[5]}");
                            Console.Write("\n Insert how mucha you wanna pass: ");
                            int value = int.Parse(Console.ReadLine());

                            if (value > 0 && value < amountAtt){
                                addData.subTransation(value);
                                data[5] = (value + int.Parse(data[5])).ToString();                
                    }}
 }           }        

    }
}}