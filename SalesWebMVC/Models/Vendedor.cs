﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário colocar o {0}")] //obrigatorio
        [StringLength(60, MinimumLength = 3, ErrorMessage ="O tamanho do {0} deve ser entre {2} e {1} caracteres!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "É necessário colocar o {0}")] //obrigatorio
        [EmailAddress(ErrorMessage ="Entre com um e-mail válido !")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "É necessário colocar a {0}")] //obrigatorio
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNasc { get; set; }


        [Required(ErrorMessage = "É necessário colocar o {0}")] //obrigatorio
        [Range(100.0, 50000.0, ErrorMessage = "O {0} deve ser no mínimo {1} e no máximo {2}")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
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
