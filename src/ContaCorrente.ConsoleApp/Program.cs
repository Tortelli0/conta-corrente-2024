namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();
            Cliente cliente1 = new Cliente();
            Cliente cliente2 = new Cliente();

            cliente1.nome = "Roberto";
            cliente1.sobrenome = "Silva";
            cliente1.cpf = "024.534.456-08";

            cliente2.nome = "Julia";
            cliente2.sobrenome = "Santos";
            cliente2.cpf = "056.123.432-10";

            conta1.CriarConta(1, 2000, 1000, false, cliente1);
            conta2.CriarConta(2, 2000, 1000, false, cliente2);

            conta1.VisualisarSaldo();
            conta1.Depositar(1000, false);
            conta1.Sacar(500, false);

            Console.WriteLine("Histórico");
            conta1.VisualizarExtrato();

            Console.WriteLine("------------------");

            conta2.VisualisarSaldo();
            conta2.Depositar(2000, false);
            conta2.Sacar(500, false);

            Console.WriteLine("Histórico");
            conta2.VisualizarExtrato();

            conta1.Transferir(100, conta2);

            Console.WriteLine("------------------");
            Console.WriteLine("Histórico");

            conta1.VisualizarExtrato();

            Console.WriteLine("------------------");
            Console.WriteLine("Histórico");
            conta2.VisualizarExtrato();

        }
    }
}