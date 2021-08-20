using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOOpt03
{
    class Carro
    {
        private string nome, marca, anoDeFabricacao, placa;

        public Carro(string nome, string marca, string anoDeFabricacao, string placa)
        {
            this.nome = nome;
            this.marca = marca;
            this.anoDeFabricacao = anoDeFabricacao;
            this.placa = placa;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return marca;
        }
        public void SetAno(string anoDeFabricacao)
        {
            this.anoDeFabricacao = anoDeFabricacao;
        }
        public string GetAno()
        {
            return anoDeFabricacao;
        }
        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }
        public string GetPlaca()
        {
            return placa;
        }
    }
}
