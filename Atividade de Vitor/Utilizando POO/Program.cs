using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizando_POO
{
    public class Program
    {
        public class Produto
        {

            public string nome;
            private double _preco;
            private int _estoque;

            public double Preco
            {
                get { return _preco; }
                set
                {
                    if (value < 0)
                    {
                        System.Console.WriteLine("Preço não pode ser negativo.");
                    }
                    else
                    {
                        _preco = value;
                    }
                }
            }

            public int Estoque
            {
                get { return _estoque; }
                set
                {
                    if (value <= 0)
                    {
                        System.Console.WriteLine("Estoque não pode ser negativo ou zero.");
                    }
                    else
                    {
                        _estoque = value;
                    }
                }
            }
        }

        public class Carro
        {
            public string nome;
            public string cor;
            public double velocidadeMaxima;
            public double velocidadeAtual;

            public void Ligar()
            {
                System.Console.WriteLine("O carro está ligado.");
                System.Console.WriteLine($"1 Marcha, velocidade atual é de {velocidadeAtual}kmh");
            }

            public void Acelerar(double quantidade)
            {
                velocidadeAtual = quantidade + velocidadeAtual;
                if (velocidadeAtual <= 20)
                {
                    System.Console.WriteLine($"1 Marcha, velocidade atual é de {velocidadeAtual}kmh");
                }
                else if (velocidadeAtual > 20 && velocidadeAtual <= 40)
                {
                    System.Console.WriteLine($"2 Marcha, velocidade atual é de {velocidadeAtual}kmh");
                }
                else if (velocidadeAtual > 40 && velocidadeAtual <= 60)
                {
                    System.Console.WriteLine($"3 Marcha, velocidade atual é de {velocidadeAtual}kmh");
                }
                else if (velocidadeAtual > 60 && velocidadeAtual <= 100)
                {
                    System.Console.WriteLine($"4 Marcha, velocidade atual é de {velocidadeAtual}kmh");
                }
                else
                {
                    System.Console.WriteLine($"5 Marcha, velocidade atual é de {velocidadeAtual}kmh");
                }
            }
        }

        public class Televisao
        {
            public int volume = 0;
            public int canal = 1;
            public string nomeCanal = "Rede TV";
            public bool power;

            public void Ligar(bool power)
            {
                if (power)
                {
                    System.Console.WriteLine("Televisão ligada");
                }
                else
                {
                    System.Console.WriteLine("Televisão desligada");
                }
            }

            public void Volume( string comando)
            {
                if(comando == "+")
                {                
                    if (volume < 100)
                        {
                            System.Console.WriteLine($"Volume {volume += 1}%");
                        }
                    else
                    {
                        System.Console.WriteLine("Volume no maximo 100%");
                    }
                }
                else if (comando == "-")
                {   
                    if (volume > 0)
                    {
                        System.Console.WriteLine($"Volume {volume -= 1}%");
                    }
                    else if (volume == 0)
                    {
                        System.Console.WriteLine("Volume no minimo 0%");
                    }
                }
                else if (comando == "x")
                {
                    System.Console.WriteLine("Mutado X");
                }
                else
                {
                    Environment.Exit(0);
                }

            }
            public void Canal(int unidade)
            {

            } 

        }
        static void Main(string[] args)
        {
            //Produto produto = new Produto();

            //produto.nome = "Caneta";
            //produto.Preco = -2;
            //produto.Estoque = -1;
            //System.Console.WriteLine("Nome: " + produto.nome);

            //Carro carro = new Carro();

            //carro.nome = "Ferrari";
            //carro.cor = "Azul";
            //carro.Ligar();
            //carro.velocidadeAtual = 2;
            //carro.Acelerar(14);
            //carro.Acelerar(2);
            //carro.Acelerar(5);
            //carro.Acelerar(16);
            //carro.Acelerar(32);
            //carro.velocidadeMaxima = 340;

            Televisao controle = new Televisao();
            controle.power = true;
            controle.Ligar(controle.power);
            bool pare;
            while (true)
            {
                Console.WriteLine("Digite o comando que quer:" +
                                "\nAumentar volume (+)" +
                                "\nDiminuir volume (-)" +
                                "\nMutar volume (x)" +
                                "\nAumentar canal (<)" +
                                "\nDiminuir canal (>)" +
                                "\nSair(_)");
                controle.Volume(Console.ReadLine());
            }
        }
    }
}
