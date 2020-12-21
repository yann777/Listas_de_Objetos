using System;
using System.Collections.Generic;
using Listas.classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1,"Apple Watch", 3522.56f));
            produtos.Add(new Produto(2,"Xiomi Watch",1522.45f));
            produtos.Add(new Produto(3,"Zenfone ASUS",2522.87f));
            produtos.Add(new Produto(4,"Samsumg S20",2522.87f));
            produtos.Add(new Produto(5,"Motorola G8",2522.87f));

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "IPhone XII";
            iphone.Preco = 8952.45f;
            produtos.Add(iphone);

             foreach (var p in produtos){
                System.Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }

            produtos.RemoveAt(3);

            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine($"\nLista alterada:");
            foreach (Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }  

            // List<int> numeros = new List<int>();
            // numeros.Add(333);
            // numeros.Add(55);
            // numeros.Add(3);
            // numeros.Add(9);

            // foreach (var item in numeros){
            //     Console.WriteLine(item);
            // }

            // List<string> nomes = new List<string>();
            // nomes.Add("Juan");
            // nomes.Add("Zé");
            // nomes.Add("Roberto");
            // nomes.Add("Luiz");
            // nomes.Add("Carlos");

            // bool resposta = nomes.Contains("Lucas");

            // if(resposta == true){
            //     Console.WriteLine("Nome encontrado");
            // }
            // else{
            //     Console.WriteLine("Nome não encontrado");
            // }

            // Console.WriteLine(nomes.Count);

            // nomes.Sort();

            // nomes.Remove("Roberto");
            // foreach (var item in nomes){
            //     Console.WriteLine(item);
            // }

            // for (var i = 0; i < nomes.Count; i++){
            //     Console.WriteLine(nomes[i]);
            //     if(nomes[i] == "Roberto"){
            //         nomes.Insert(i,"Robertinho");
            //     }
            // }

            // foreach (var item in nomes){
            //     Console.WriteLine(item);
            // }

            // foreach (var item in nomes){
            //     if(item == "Zé"){
            //         Console.WriteLine("Nome encontrado");
            //     }
            //      else{
            //          Console.WriteLine("Nome não encontrado");
            //      }
            // }
        }
    }
}
