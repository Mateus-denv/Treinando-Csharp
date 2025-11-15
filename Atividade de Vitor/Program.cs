using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Práticas C#1");
            while (true)
            {
                Console.WriteLine("=========================================================\nDigite a questão que deseija ver (1-21):");
                int questao = int.Parse(Console.ReadLine());
                switch (questao)
                {
                    case 1:
                        Console.WriteLine("Digite um valor: ");
                        double valorP = double.Parse(Console.ReadLine());

                        double taxaS = valorP * 0.20;
                        double total = valorP - taxaS;

                        Console.WriteLine($"Taxa de serviço aplicada R${taxaS}");
                        Console.WriteLine($"Total {total.ToString("F2")}");
                        continue;

                    case 2:
                        Console.WriteLine("Digite a Altura:");
                        int altura = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a Largura:");
                        int largura = int.Parse(Console.ReadLine());
                        Console.WriteLine("Área: " + (altura * largura) + "m²");

                        var tintaNescessaria = altura * largura;
                        Console.WriteLine($"Quantidade de tinta nescessaria: {tintaNescessaria}L");
                        continue;

                    case 3:
                        double salarioLiquido, inss, descontoPlano;
                        Console.WriteLine("Digite o seu salário:");
                        double salarioBruto = double.Parse(Console.ReadLine());
                        
                        descontoPlano = 150.00;
                        inss = salarioBruto * 0.08;
                        Console.WriteLine($"Descontos:\nPLANO DE SAÚDE: R${descontoPlano}\nINSS: R${inss.ToString("F2")}");
                        salarioLiquido = salarioBruto - (descontoPlano +  inss); //descontos

                        Console.WriteLine($"O seu salario liquido após descontos é de {salarioLiquido.ToString("F2")}");
                        continue;

                    case 4:
                        float nota1, nota2, media;
                        Console.WriteLine("Digite a primeira nota:");
                        nota1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a segunda nota:");
                        nota2 = float.Parse(Console.ReadLine());
                        media = (nota1 + nota2) / 2;
                        Console.WriteLine($"Média: {media}");
                        if (media >= 7)
                        {
                            Console.WriteLine("Você foi aprovado");
                        }
                        else if( media < 7 && media >=5)
                        {
                            Console.WriteLine("Você está em recuperação");
                        }
                        else
                        {
                            Console.WriteLine("Você foi reprovado");
                        }
                            continue;

                    case 5:
                        int tipoAutomovel;
                        Console.WriteLine("Digite o tipo de Automovel a dirigir\n1-Carro\n2-Van\n3-Caminhão");
                        tipoAutomovel = int.Parse(Console.ReadLine());
                        switch (tipoAutomovel)
                        {
                            case 1:
                                const double valorKmCarro = 0.20;
                                Console.WriteLine("Qual a distancia a ser percorrida? Em km");
                                var kmPercorrido = double.Parse(Console.ReadLine());
                                double valorDaViagem = kmPercorrido * valorKmCarro;
                                Console.WriteLine($"O valor da viagem é de R${valorDaViagem:F2}");
                                continue;
                            case 2:
                                const double valorKmVan = 0.70;
                                Console.WriteLine("Qual a distancia a ser percorrida? Em km");
                                var kmPercorridoVan = double.Parse(Console.ReadLine());
                                double valorDaViagemVan = kmPercorridoVan * valorKmVan;
                                Console.WriteLine($"O valor da viagem é de R${valorDaViagemVan:F2}");
                                continue;

                            case 3:
                                const double valorKmCaminhao = 1.20;
                                Console.WriteLine("Qual a distancia a ser percorrida? Em km");
                                var kmPercorridoCaminhao = double.Parse(Console.ReadLine());
                                double valorDaViagemCaminhao = kmPercorridoCaminhao * valorKmCaminhao;
                                Console.WriteLine($"O valor da viagem é de R${valorDaViagemCaminhao:F2}");
                                continue;
                            default:
                                Console.WriteLine("Tipo de automovel inválido");
                                continue;
                        }

                    case 6:
                        Console.WriteLine("Questão em Desenvolvimento");
                        string nomeProduto = "";
                        int quantidadeProduto = 0;
                        double precoProduto = 0.0;
                        int add = 1;

                        while (add == 1)
                        {
                            Console.WriteLine("Digite o nome do Produto que deseja retirar:");
                            nomeProduto = Console.ReadLine();
                            Console.WriteLine("Digite a quantidade em estoque:");
                            quantidadeProduto = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o preço do produto:");
                            precoProduto = double.Parse(Console.ReadLine());
                            double valorTotal = quantidadeProduto * precoProduto;

                            if (valorTotal > 500.00)
                            {
                                Console.WriteLine("\nSerá aplicado um desconto de 10% em cima do valor total do produto.");
                                Console.WriteLine($"Valor atual: R${valorTotal:F2}");
                                
                                double valorComDesconto =  valorTotal - (valorTotal * 0.10);
                                Console.WriteLine($"Valor após o desconto: R${valorComDesconto:F2}");
                            }
                            else if (valorTotal > 1000.00)
                            {
                                Console.WriteLine("\nSerá aplicado um desconto de 15% em cima do valor total do produto.");
                                Console.WriteLine($"Valor atual: R${valorTotal:F2}");

                                double valorComDesconto = valorTotal - (valorTotal * 0.15);
                                Console.WriteLine($"Valor após o desconto: R${valorComDesconto:F2}");
                            }
                            else
                            {
                                Console.WriteLine($"Valor atual: R${valorTotal:F2}");
                            }
                            Console.WriteLine("Deseja adicionar outro produto? (1-Sim/0-Não)");
                            add = int.Parse(Console.ReadLine());
                            
                        }
                        continue;

                    case 7:
                        int diaDaSemana;
                        Console.WriteLine("Digite um número de 1 a 7 para saber o dia da semana correspondente:" +
                            "\n1-Segunda-Feira" +
                            "\n2-Terça-Feira" +
                            "\n3-Quarta-Feira" +
                            "\n4-Quinta-Feira" +
                            "\n5-Sexta-Feira" +
                            "\n6-Sabádo" +
                            "\n7-Domingo" +
                            "\nEsse será o dia que utilizara o ingresso.");
                        diaDaSemana = int.Parse(Console.ReadLine());

                        switch(diaDaSemana)
                        {
                            case 1:
                                Console.WriteLine("Segunda-Feira");
                                Console.WriteLine("O valor do seu ingreço é de R$20,00");

                                break;
                            case 2:
                                Console.WriteLine("Terça-Feira");
                                Console.WriteLine("O valor do seu ingreço é de R$20,00");

                                break;
                            case 3:
                                Console.WriteLine("Quarta-Feira");
                                Console.WriteLine("O valor do seu ingreço é de R$20,00");

                                break;
                            case 4:
                                Console.WriteLine("Quinta-Feira");
                                Console.WriteLine("O valor do seu ingreço é de R$20,00");

                                break;
                            case 5:
                                Console.WriteLine("Sexta-Feira");
                                Console.WriteLine("O valor do seu ingreço é de R$25,00");

                                break;
                            case 6:
                                Console.WriteLine("Sabádo");
                                Console.WriteLine("O valor do seu ingreço é de R$30,00");

                                break;
                            case 7:
                                Console.WriteLine("Domingo");
                                Console.WriteLine("O valor do seu ingreço é de R$30,00");

                                break;
                            default:
                                Console.WriteLine("Número inválido, tente novamente.");
                                continue;
                        }
                        continue;

                    case 8:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 9:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 10:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 11:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 12:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 13:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 14:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 15:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 16:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 17:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 18:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;
                    case 19:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 20:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 21:
                        Console.WriteLine("Questão em Desenvolvimento");

                        continue;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Essa questão não existe");

                        break;

                }
                break;
            }
        }
    }
}