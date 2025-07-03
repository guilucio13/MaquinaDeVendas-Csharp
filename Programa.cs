using System.ComponentModel.Design;
using System.Globalization;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;
using PrimeiroProjeto.PrimeiroProjeto;


namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //criando uma instância ja com o estoque
            MaquinaDeVendas maquina = new MaquinaDeVendas(10, 15, 5);

            //exibindo o menu
            maquina.ExibirProdutos();

            //adicionando um valor
            Console.WriteLine("você inseriu R$ 2,00");
            maquina.InserirDinheiro(2.0);

            Console.WriteLine(); //quebra de linha

            //tentando comprar com crédito insuficiente
            maquina.SelecionarProduto(2);

            //adicionando mais dinheiro
            Console.WriteLine("você inseriu mais R$ 5,00");
            maquina.InserirDinheiro(7.0);

            Console.WriteLine(); //quebra de linha

            //comprando um chocolate
            maquina.SelecionarProduto(2);

            Console.WriteLine(); //quebra de linha

            //comprando um refrigerante
            maquina.SelecionarProduto(1);

            Console.WriteLine(); //quebra de linha

            //exibindo os produtos novamente com estoque atualizado
            maquina.ExibirProdutos();

            Console.WriteLine(); //quebra de linha

            //pedindo o troco
            maquina.DevolverTroco();

            //tentando pedir o troco novamente (deve dizer que não há troco)
            maquina.DevolverTroco();

            Console.WriteLine();//quebra de linha

            // testando o método reabastecer
            maquina.Reabastecer(3, 0);

            Console.WriteLine(); //qubra de linha

            //exibindo o estoque novamente
            maquina.ExibirProdutos();




























        }
    }
}
