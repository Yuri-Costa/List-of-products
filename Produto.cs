using System;
using System.Collections.Generic;

namespace Listing
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto(){}

        List<Produto> produtos = new List<Produto>();
        private int senha = 4444;
        public int Senha { get{return senha;} }
        public Produto ( int _codigo, string _nome, float _preco){

            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

            public void MostrarLista(){
            produtos.Add(new Produto(1, "camiseta", 20));
            produtos.Add(new Produto(2, "moletom", 100));
            produtos.Add(new Produto(3, "jaqueta", 120));
            produtos.Add(new Produto(4, "boné", 60));
            produtos.Add(new Produto(5, "tenis", 200));

            foreach (var p in produtos)
            {
                Console.ForegroundColor=ConsoleColor.Cyan;
                Console.WriteLine($"Codigo: [{p.Codigo}], Nome: {p.Nome}, preço: R${p.Preco}");
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine("deseja comprar este item?(insira o codigo dele)");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();
            }


        }

            public void ComprarItem(){
            Console.ForegroundColor=ConsoleColor.Magenta;

            int resposta = int.Parse(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.Blue;

           switch (resposta)
            {
            case 1:
            Console.WriteLine($"insira a senha para a compra da camiseta!");
            PedirSenha();
            break;

            case 2:
            Console.WriteLine($"insira a senha para compra do moletom!");
            PedirSenha();
            break;

            case 3:
            Console.WriteLine($"insira a senha para compra da jaqueta!");
            PedirSenha();
            break;

            case 4:
            Console.WriteLine($"insira a senha para compra do boné!");
            PedirSenha();
            break;

            case 5:
            Console.WriteLine($"insira a senha para compra do tenis!");
            PedirSenha();
            break;

            default:
            break;
           }}        

            public void PedirSenha(){
            int senhaDeAcesso = int.Parse(Console.ReadLine());
            if (senhaDeAcesso == Senha)
            {Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"translação aceita!");
            }
            else{Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("traslação negada! senha incorreta!");}
            }
        
        
        
        
        
    }
}