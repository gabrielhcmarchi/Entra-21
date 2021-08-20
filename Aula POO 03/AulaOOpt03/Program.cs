using System;

namespace AulaOOpt03
{
    class Program
    {
        static void Main(string[] args)
        {
            ////exec01
            ///
            //Console.WriteLine("Preencha um cachorro");
            //string nome, raca;
            //int idade;
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());

            //Cachorro cao = new Cachorro(nome, raca, idade);

            //Console.WriteLine("--------------");
            //Console.WriteLine(cao.GetNome());
            //Console.WriteLine(cao.GetRaca());
            //Console.WriteLine(cao.GetIdade());
            ////set
            //Console.WriteLine();
            //Console.WriteLine("same");
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());
            //cao.SetNome(nome);
            //cao.SetRaca(raca);
            //cao.SetIdade(idade);
            //Console.WriteLine("--------------");
            //Console.WriteLine(cao.GetNome());
            //Console.WriteLine(cao.GetRaca());
            //Console.WriteLine(cao.GetIdade());

            //exec02

            //Console.WriteLine("Preencha um carro");
            //string nome, marca, anoDeFabricacao, placa;
            //nome = Console.ReadLine();
            //marca = Console.ReadLine();
            //anoDeFabricacao = Console.ReadLine();
            //placa = Console.ReadLine();
            //Carro veiculo = new Carro(nome, marca, anoDeFabricacao,placa);
            //Console.WriteLine("--------------------------");
            //Console.WriteLine(veiculo.GetNome());
            //Console.WriteLine(veiculo.GetMarca());
            //Console.WriteLine(veiculo.GetAno());
            //Console.WriteLine(veiculo.GetPlaca());

            //set
            //Console.WriteLine();
            //Console.WriteLine("same");
            //nome = Console.ReadLine();
            //marca = Console.ReadLine();
            //anoDeFabricacao = Console.ReadLine();
            //veiculo.SetNome(nome);
            //veiculo.SetMarca(marca);
            //veiculo.SetAno(anoDeFabricacao);
            //veiculo.SetPlaca(placa);
            //Console.WriteLine("--------------");
            //Console.WriteLine(veiculo.GetNome());
            //Console.WriteLine(veiculo.GetMarca());
            //Console.WriteLine(veiculo.GetAno());
            //Console.WriteLine(veiculo.GetPlaca());

            //exec03

            //while (true)
            //{

            //    Console.WriteLine("| ------------------------- |");
            //    Console.WriteLine("|insira uma pessoa          |");
            //    Console.WriteLine("|nome, cpf e idade|");
            //    Console.WriteLine("| ------------------------- |");
            //    string nome, cpf;
            //    int idade;
            //    nome = Console.ReadLine();
            //    cpf = Console.ReadLine();
            //    idade = int.Parse(Console.ReadLine());
            //    Pessoa pes = new Pessoa(nome, cpf, idade);
            //    Console.WriteLine();
            //    Console.WriteLine("| -------------------- |");
            //    Console.WriteLine("|" + pes.GetNome()); ;
            //    Console.WriteLine("| -------------------- |");
            //    Console.WriteLine("|" + pes.GetCpf());
            //    Console.WriteLine("| -------------------- |");
            //    Console.WriteLine("|" + pes.GetIdade());
            //    Console.WriteLine("| -------------------- |");

            //    Console.WriteLine("Deseja alterar a pessoa inserida? s ou n ");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "s")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("| ------------------------- |");
            //        Console.WriteLine("|insira uma pessoa          |");
            //        Console.WriteLine("|nome, cpf e idade|");
            //        Console.WriteLine("| ------------------------- |");
            //        nome = Console.ReadLine();
            //        cpf = Console.ReadLine();
            //        idade = int.Parse(Console.ReadLine());
            //        pes.SetNome(nome);
            //        pes.SetIdade(idade);
            //        pes.SetCpf(cpf);
            //        Console.WriteLine("| -------------------- |");
            //        Console.WriteLine("|" + pes.GetNome()); ;
            //        Console.WriteLine("| -------------------- |");
            //        Console.WriteLine("|" + pes.GetCpf());
            //        Console.WriteLine("| -------------------- |");
            //        Console.WriteLine("|" + pes.GetIdade());
            //        Console.WriteLine("| -------------------- |");
            //        Console.WriteLine();
            //        Console.WriteLine("enter pra continuar");
            //        Console.ReadLine();
            //    }
            //    else if (escolha == "n")
            //    {
            //        break;
            //    }

            //}

            //exec04

            //cliente vazio pra preencher usando set
            //Cliente cli = new Cliente("", "", new string[1]);
            //Console.WriteLine("cleinte");
            //string nome = Console.ReadLine();
            //string cpf = Console.ReadLine();
            //Console.WriteLine("consult");
            //Console.WriteLine("s pra sair");
            //string[] consultas = new string[10];
            //int indice = 0;

            //while (true)
            //{
            //    string saida = Console.ReadLine();
            //    if (saida == "s")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        consultas[indice] = saida;
            //        indice++;
            //    }
            //    catch (IndexOutOfRangeException)
            //    {
            //        Console.WriteLine("limite atingido");
            //        break;
            //    }
            //}
            //cli.SetNome(nome);
            //cli.SetCpf(cpf);
            //cli.SetConsultas(consultas);

            //Console.WriteLine(cli.GetNome());
            //Console.WriteLine(cli.GetCpf());
            ////string[] consultasFinal = cli.GetConsultas();
            //for (int i = 0; i < cli.GetConsultas().Length; i++)
            //{
            //    if (cli.GetConsultas()[i] == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(cli.GetConsultas()[i]);
            //}


        }
    }
}
