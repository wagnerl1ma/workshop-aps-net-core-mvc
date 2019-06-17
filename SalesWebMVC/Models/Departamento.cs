using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMVC.Models {

    public class Departamento 
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //associação da classe Departamento c/ a classe Vendedor
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        //total de vendas dos vendedores
        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendas(inicio, final));
        }
    }
}
