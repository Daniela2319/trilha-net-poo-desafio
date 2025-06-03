using DesafioPOO.Models;

namespace trilha_net_poo_desafio.Models
{
    public class MenuNokia : Nokia
    {
   
        public MenuNokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public void ExibirMenu()
        {
            ImprimirCabecalho();
            UsarDoWhile();
        }


        public void ImprimirCabecalho()
        {
            Console.WriteLine("Bem-vindo ao Menu Nokia!");
            Console.WriteLine("-------------------------");
        }
        public void ImprimirRodape()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Obrigado por usar o Menu Nokia!");
        }
        public int LerOpcaoUsuario()
        {
            System.Console.WriteLine("Digite a opção desejada:");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Receber Ligação");
            Console.WriteLine("3 - Instalar Aplicativo");
            Console.WriteLine("0 - Sair");
        }
        public void ExecutarOpcoesMenu(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Ligar();
                    break;
                case 2:
                    ReceberLigacao();
                    break;
                case 3:
                    Console.Write("Digite o nome do aplicativo: ");
                    string app = Console.ReadLine();
                    InstalarAplicativo(app);
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public void UsarDoWhile()
        {
            int opcao;
            do
            {
            ImprimirCabecalho();
            ImprimirMenu();
            opcao = LerOpcaoUsuario();
            ExecutarOpcoesMenu(opcao);
            ImprimirRodape();
            } while (opcao != 0);
        }

    }
}