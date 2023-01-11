namespace ByteBank {
    public class Program {

        private static void ShowMenu() {
            Console.Clear();
            Console.WriteLine("*********           BYTE BANK         *********");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                  MENU PRINCIPAL               ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("     1 - Inserir novo usuário");
         g   Console.WriteLine("     2 - Deletar um usuário");
            Console.WriteLine("     3 - Listar todas as contas regisradas");
            Console.WriteLine("     4 - Detalhes de um usuário");
            Console.WriteLine("     5 - Total armazenado no banco");
            Console.WriteLine("     6 - Movimentar uma conta");
            Console.WriteLine("     0 - Para sair do programa");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.Write("Digite a opção desejada: ");
        }

        private static void MenuConta() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("             MOVIMENTÇÃO DE CONTA              ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("     1 - Consultar Saldo");
            Console.WriteLine("     2 - Realizar Depósito");
            Console.WriteLine("     3 - Realizar Saque");
            Console.WriteLine("     4 - Realizar Transferência");
            Console.WriteLine("     0 - Voltar ao menu anterior");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.Write("Digite a opção desejada: ");

            int opcao = int.Parse(Console.ReadLine());

            switch(opcao) {
                case 0:
                    ShowMenu();
                    break;
                case 1:
                    Console.WriteLine("Seu Saldo é de:  R$ ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("----  Aperte ENTER para voltar ao MENU  ----");
                    Console.ReadLine();
                    Console.Clear();
                    ShowMenu();
                    break;
                case 2:
                    Console.WriteLine("Depósito");
                    break;
                case 3:
                    Console.WriteLine("Saque");
                    break;
                case 4:
                    Console.WriteLine("Transferência");
                    break;
            }

        }

        private static void CriarUsuario(List<string> nomes,List<string> cpfs,List<string> senhas,List<double> saldos) {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("              CADASTRO DE USUÁRIO           ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Digite seu Nome: ");
            nomes.Add(Console.ReadLine());
            Console.Write("Digite seu CPF: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Digite sua Senha: ");
            string senha1 = Console.ReadLine();
            Console.Write("Confirme sua Senha: ");
            string confirmarSenha = Console.ReadLine();

            while(senha1 != confirmarSenha) {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("            SENHAS NÃO CONFEREM!            ");
                Console.WriteLine("              Tente Novamente!              ");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("");
                Console.Write("Digite sua Senha: ");
                senha1 = Console.ReadLine();
                Console.Write("Confirme sua Senha: ");
                confirmarSenha = Console.ReadLine();
            }

            senhas.Add(confirmarSenha);
            saldos.Add(0);

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("       USUÁRIO CADASTRADO COM SUCESSO!      ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("----  Aperte ENTER para voltar ao MENU  ----");
            Console.ReadLine();
            Console.Clear();
        }

        private static void DeletarUsuario(List<string> nomes,List<string> cpfs,List<string> senhas,List<double> saldos) {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("                DELETAR USUÁRIO             ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.Write("Digite o CPF do usuário que deseja deletar: ");
            Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("        USUÁRIO DELETADO COM SUCESSO!       ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("----  Aperte ENTER para voltar ao MENU  ----");
            Console.ReadLine();
            Console.Clear();
        }








        private static void SairDoPrograma() {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("            ENCERRANDO PROGRAMA...          ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
        }





        static void Main(string[] args) {

            List<string> nomes = new List<string>();
            List<string> cpfs = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();
            int opcao;

            do {
                ShowMenu();
                opcao = int.Parse(Console.ReadLine());


                switch(opcao) {
                    case 1:
                        Console.WriteLine("");
                        CriarUsuario(nomes,cpfs,senhas,saldos);
                        break;
                    case 2:
                        Console.WriteLine("");
                        DeletarUsuario(nomes,cpfs,senhas,saldos);
                        break;
                    case 3:
                        Console.WriteLine("");
                        
                        break;
                    case 4:
                        Console.WriteLine("");
                        
                        break;
                    case 5:
                        Console.WriteLine("");
                        
                        break;
                    case 6:
                        Console.WriteLine("");
                        MenuConta();
                        break;
                    case 0:
                        Console.Clear();
                        SairDoPrograma();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("              OPÇÃO INVÁLIDA!             ");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("---  Aperte ENTER para tentar novamente  ---");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            while(opcao != 0);

        }
    }
}
