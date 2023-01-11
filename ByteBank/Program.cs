namespace ByteBank {
    public class Program {


        static void Main(string[] args) {

            List<string> nomes = new List<string>();
            List<string> cpfs = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();
            int opcao;

            do {
                Console.WriteLine("*********    Bem-vindo ao ByteBank    *********");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("     1 - Inserir novo usuário");
                Console.WriteLine("     2 - Deletar um usuário");
                Console.WriteLine("     3 - Listar todas as contas regisradas");
                Console.WriteLine("     4 - Detalhes de um usuário");
                Console.WriteLine("     5 - Total armazenado no banco");
                Console.WriteLine("     6 - Manipular a conta");
                Console.WriteLine("     0 - Para sair do programa");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());


                switch(opcao) {
                    case 1:
                        Console.WriteLine("");
                        CriarUsuario(nomes,cpfs,senhas,saldos);
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Opção 2");
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Opção 3");
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Opção 4");
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Opção 5");
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("Opção 6");
                        break;
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("              OPÇÃO INVÁLIDA!             ");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("---  Aperte Enter para tentar novamente  ---");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            while(opcao != 0);

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
            senhas.Add(Console.ReadLine());
            saldos.Add(0);

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("       Usuário Cadastrado com sucesso!      ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("---  Aperte Enter para o Menu Principal  ---");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
