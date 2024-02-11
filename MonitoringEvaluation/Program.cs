using System.Globalization;
using System.Text;
using System.Net;
using System.IO;
using System;

namespace MonitoringEvaluation {
    class Program {
        static void Main(string[] args) {

            bool menu = true;

            while(menu) {

                Console.Write("\n   Monitorador de sites \n | 1 – Monitorar \n | 2 – Registrar site \n | 3 – Exibir logs \n | 0 – Sair \n\n > Escolha uma opcao: ");
                string opc = Console.ReadLine();
                int status = 0;

                switch (opc) {
                    case "1": //bloco 1 - monitoramento basico

                        if (!File.Exists("sites.txt")) {
                            Console.WriteLine("\n  Arquivo nao identificado ou inexistente!");
                        } else {

                            Console.WriteLine("\n   --- REGISTROS --- ");
                            FileStream arqRead = new FileStream("sites.txt", FileMode.Open, FileAccess.Read, FileShare.Read);            

                            foreach (string line in File.ReadLines("sites.txt")) {  //leitura do arquivo linha-linha

                                try {

                                    if (line != null) {  //le linha por linha do texto, ate se deparar com linhas "nulas"(fim do texto)

                                        try {
                                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(line); //requisiçao web
                                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                                            status = (int)response.StatusCode;
                                            sitesLogs(line, true, "sites.txt");

                                            Console.WriteLine($"\n  URL: {line}\n  STATUS: Sucesso ao carregar!\n  STATUS CODE: {status}");
                                        } catch (WebException e) {
                                            Console.WriteLine((status == 200) ? $"\n  URL: {line}\n  STATUS: Falha ao carregar!\n  STATUS CODE: Requisiçao bem sucedida, mas ainda apresenta falha na conexao." : 
                                                                                $"\n  URL: {line}\n  STATUS: Falha ao carregar!\n  STATUS CODE: {status}");
                                            sitesLogs(line, false, "sites.txt");
                                        }
                                        System.Threading.Thread.Sleep(2000);
                                    }

                                } catch (IOException e) {
                                    Console.WriteLine(" > Erro na leitura do arquivo. \n > " + e.Message);
                                }
                            }
                            arqRead.Close();  //fim do bloco 1 - monitoramento basico
                        }

                    break;
                    case "2":
                        Console.Write("Informe quantos sites deseja cadastrar: ");
                        int qntdSite = int.Parse(Console.ReadLine());

                        try {
                            StreamWriter arqSites = new StreamWriter("sites.txt", true, Encoding.Unicode);
                            string text = "";

                            for(int newSite = 1; newSite <= qntdSite; newSite++) { //Conteudo do arquivo, quando o usuario digitar 0 o loop para -> !!!!!!!!
                                Console.Write($" Site registrado {newSite}:    ");
                                text = Console.ReadLine(); //linha por linha do texto sendo capturada
                                arqSites.WriteLine("https://" + text);
                            }
                            arqSites.Close();

                        } catch (Exception e) {
                            Console.WriteLine(" > Erro no cadastro do site! \n > ", e.Message);  
                        } 

                    break;
                    case "3":

                        if (File.Exists("logs.txt")) {
                            Console.WriteLine("\n    --- LOGS ---");
                            mostrarLogs();
                        } else {
                            Console.WriteLine("\n  Nenhum site cadastrado!");
                        }

                    break;
                    case "0":

                        Console.WriteLine("\n    Program finished.");
                        arquivoExistente();

                        menu = false;

                    break;
                    default:
                        Console.WriteLine("\n Opçao invalida.");
                    break;

                }
            }
        }
        public static void arquivoExistente(){
                
            if(File.Exists("sites.txt") || File.Exists("logs.txt")) {
                File.Delete("sites.txt"); 
                File.Delete("logs.txt");
            }

        }
        public static void mostrarLogs(){

            FileStream arqRead = new FileStream("logs.txt", FileMode.Open, FileAccess.Read, FileShare.Read);            
            foreach (string line in File.ReadLines("logs.txt")){
                
                if (line != null) { Console.WriteLine(line); }

            }
        }
        public static void sitesLogs(string sites, bool code, string registros) {

            StreamWriter arqLogs = new StreamWriter("logs.txt", true, Encoding.Unicode);
            File.SetLastWriteTime($"{registros}", DateTime.Now);
            
            string logs = ($"\n   URL: {sites}\n   {File.GetLastWriteTime("sites.txt")}\n   Conection Status: {code}\n");
            arqLogs.WriteLine(logs);
            
            arqLogs.Close();
        }
    }
}