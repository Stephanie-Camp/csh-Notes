namespace Bank {
    class EncryptPass {
        
        private string Pass;
        private string[,] CryptoTable = new string[,] {
            {"a", "J8IEap"}, {"b", "5ejbfH"}, {"c", "Zpxnv0"}, {"d", "3G7GBs"}, {"e", "dx8ePÇ"}, {"f", "4jKeDN"}, {"g", "fvC9qp"}, {"h", "fmka1F"}, {"i", "eanw6G"}, {"j", "kwIOV4"}, 
            {"k", "1HFbkq"}, {"l", "5tgABQ"}, {"m", "kal9UQ"}, {"n", "7FdkwG"}, {"o", "ÇZ0acZ"}, {"p", "LXg2ol"}, {"q", "Uys9YS"}, {"r", "oKD5dv"}, {"s", "anG9aQ"}, {"t", "0falMn"}, 
            {"u", "h1bIWm"}, {"v", "7eKsDu"}, {"w", "çwnQ5H"}, {"x", "F2kmEn"}, {"y", "po2sNe"}, {"z", "fIqNx0"}, {"ç", "19emJAi02"}, 
            {"1", "gyvhVHG"}, {"2", "opSDnjA"}, {"3", "QWSxvIK"}, {"4", "GVrCTUY"}, {"5", "NlpkbAv"}, {"6", "BtyrTGY"}, {"7", "pQKohwV"}, {"8", "ÇALFtwb"}, {"9", "rijUUGB"}, {"0", "amWTZxo"}, 
            {"A", "b372vS"}, {"B", "aK927b"}, {"C", "10DB7a"}, {"D", "ç28Hc1"}, {"E", "xO94j5"}, {"F", "1nDa07"}, {"G", "Qn71K6"}, {"H", "n2N48ç"}, {"I", "a8E9Q2"}, {"J", "Uu3p20"}, 
            {"K", "26Gç8A"}, {"L", "L0C6j1"}, {"M", "ahw935"}, {"N", "Y1b8Q0"}, {"O", "19ns0X"}, {"P", "K23Vo1"}, {"Q", "n0s36b"}, {"R", "829Gwz"}, {"S", "02d6pG"}, {"T", "akn176"}, 
            {"U", "dn78A0"}, {"V", "XkQ945"}, {"W", "4bGu10"}, {"X", "2J6z1r"}, {"Y", "47WvF3"}, {"Z", "g3w2K9"}, {"Ç", "20IajME91"} 
        };

        public EncryptPass(string clientPass) {
            Pass = passwordEncrypted(clientPass); //nao ha acesso direto a senha
        }
        //metodo get para conseguirmos acessar a senha criptografada
        public string GetPassword() {
            return Pass;
        }
        //onde a senha esta sendo diretamente passada para ser criptografada
        private string passwordEncrypted(string pass) {
            string[] newPass = new string[pass.Length]; //tam definido pela classe
            if(newPass.Length != 8)
                return "0";

            for (int caractere = 0; caractere < CryptoTable.GetLength(0); caractere++) {
                for (int i = 0; i < pass.Length; i++) {

                    if (pass[i].ToString() == CryptoTable[caractere, 0]) { //cada elemento da senha sendo substituida 
                        newPass[i] = (CryptoTable[caractere, 1]);
                    }
                }
            }
            return string.Join("", newPass); //retorno da senha criptografada
        }

    }
}