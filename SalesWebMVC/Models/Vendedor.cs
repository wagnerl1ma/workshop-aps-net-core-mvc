using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        //associação classe vendedor com a classe Registro Vendas
        public ICollection<RegistrosDeVendas> Vendas { get; set; } = new List<RegistrosDeVendas>();


        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNasc, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }


        //adicionar uma venda na lista de venda
        public void AddVenda(RegistrosDeVendas rv)
        {
            Vendas.Add(rv); 
        }

        //Remover uma venda na lista de venda
        public void RemoveVenda(RegistrosDeVendas rv)
        {
            Vendas.Remove(rv);
        }


        //total de vendas do vendedor em uma determinada data
        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= final).Sum(rv => rv.Quantidade);
        }
    }
}
