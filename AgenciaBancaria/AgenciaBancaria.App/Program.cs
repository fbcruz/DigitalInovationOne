using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "123456", "Barra Bonita", "SP");
                Cliente cliente = new Cliente("Franciele", "123456789", "123456", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta Criada: " + conta.Situacao + ":" + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Abrir("abc123");

                Console.WriteLine("Conta Criada: " + conta.Situacao + ":" + conta.NumeroConta + "-" + conta.DigitoVerificador);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
