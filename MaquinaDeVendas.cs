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
using System.ComponentModel.Design;

namespace PrimeiroProjeto
{
    namespace PrimeiroProjeto
    {
        internal class MaquinaDeVendas
        {
            //propriedade estoque
            public int EstoqueRefri { get; private set; }
            public int EstoqueChocolate { get; private set; }
            public int EstoqueSalgadinho { get; private set; }
            public double CreditoAtual { get; private set; }

            //propriedade preço
            public double PrecoRefri { get; private set; }
            public double PrecoChocolate { get; private set; }
            public double PrecoSalgadinho { get; private set; }

            //construtor
            public MaquinaDeVendas(int estoquerefri, int estoquechocolate, int estoquesalgadinho)
            {
                //estoque
                EstoqueRefri = estoquerefri;
                EstoqueChocolate = estoquechocolate;
                EstoqueSalgadinho = estoquesalgadinho;

                //preço
                PrecoRefri = 5.0;
                PrecoChocolate = 3.50;
                PrecoSalgadinho = 4.0;

                //credito atual começa em 0
                CreditoAtual = 0;
            }

            //método para exibir o cardapio
            public void ExibirProdutos()
            {
                Console.WriteLine("---- MÁQUINA DE VENDAS ----");
                Console.WriteLine("Produtos disponníveis:");
                Console.WriteLine(); // quebra de linha 
                Console.WriteLine($"[1] Refrigerante | Preço: {this.PrecoRefri} | Estoque: {this.EstoqueRefri}");
                Console.WriteLine($"[2] Chocolate | Preço: {this.PrecoChocolate} | Estoque: {this.EstoqueChocolate}");
                Console.WriteLine($"[3] Salgadinho | Preço: {this.PrecoSalgadinho} | Estoque: {this.EstoqueSalgadinho}");
                Console.WriteLine($"Crédito atual: {this.CreditoAtual}");
                Console.WriteLine(); //quebra de linha 
            }

            //método para inserir credito
            public void InserirDinheiro(double valor)
            {
                CreditoAtual += valor;
                Console.WriteLine($"Crédito atual: { CreditoAtual}");
            }


            //método para reabastecer 
            public void Reabastecer(int codigoProduto, int quantidade)
            {
                switch (codigoProduto)
                {
                    case 1: //usuario selecionou refri

                        if (quantidade <= 0)
                        {
                            Console.WriteLine("a quantidade a ser abastecida deve ser maior que zero!");
                            return;
                        }
                      
                        {
                            this.EstoqueRefri += quantidade;

                            Console.WriteLine($"você adicionou {quantidade} ao estoque de refri");
                        }
                        break;


                    case 2://usuario selecionou chocolate

                        {
                            this.EstoqueChocolate += quantidade;

                            Console.WriteLine($"você adicionou {quantidade} ao estoque de chocolate");
                        }
                        break;


                    case 3://usuario selecionou salgadinho

                        {
                            this.EstoqueSalgadinho += quantidade;

                            Console.WriteLine($"você adicionou {quantidade} ao estoque de salgadinho");
                        }
                        break;

                    default:
                        Console.WriteLine("opção inválida!");
                        break;
                }

            }

            //metodo para selecionar o produto 
            public void SelecionarProduto(int codigo)
            {
                switch (codigo)
                {
                    case 1: //usuario escolheu refrigerante 
                        if (this.CreditoAtual >= this.PrecoRefri)
                        {
                            if (this.EstoqueRefri > 0)
                            {
                                Console.WriteLine("Compra aprovada! Retire seu refrigerante.");
                                this.CreditoAtual -= this.PrecoRefri;
                                this.EstoqueRefri--;
                            }
                            else
                            {
                                Console.WriteLine("Não possui estoque!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("não possui crédito!");
                        }
                        break;

                    case 2: //usuario escolheu chocolate
                        if (this.CreditoAtual >= this.PrecoChocolate)
                        {
                            if (this.EstoqueChocolate > 0)
                            {
                                Console.WriteLine("Compra aprovada! Retire seu chocolate.");
                                this.CreditoAtual -= this.PrecoChocolate;
                                this.EstoqueChocolate--;
                            }
                            else
                            {
                                Console.WriteLine("Não possui estoque!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("não possui crédito!");
                        }
                        break;

                    case 3: //usuario escolheu salgadinho
                        if (this.CreditoAtual >= this.PrecoSalgadinho)
                        {
                            if (this.EstoqueSalgadinho > 0)
                            {
                                Console.WriteLine("Compra aprovada! Retire seu refrigerante.");
                                this.CreditoAtual -= this.PrecoSalgadinho;
                                this.EstoqueSalgadinho--;
                            }
                            else
                            {
                                Console.WriteLine("Não possui estoque!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("não possui crédito!");
                        }
                        break;

                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }
            }

            //método pra devolver o troco
            public void DevolverTroco()
            {
                if (this.CreditoAtual > 0)
                {
                    Console.WriteLine($"Devolvendo seu troco de {CreditoAtual}");
                    CreditoAtual = 0;
                }
                else 
                {
                    Console.WriteLine("não há trocos para devolver");
                }

            }
        }
    }

}