using SalesWebMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class RegistrosDeVendas
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Quantidade { get; set; } 

        public StatusVendas Status { get; set; }

        public Vendedor Vendedor { get; set; }

        public RegistrosDeVendas()
        {

        }

        public RegistrosDeVendas(int id, DateTime data, double quantidade, StatusVendas status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
