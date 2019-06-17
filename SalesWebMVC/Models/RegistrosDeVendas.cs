using SalesWebMVC.Models.Enums;
using System;

namespace SalesWebMVC.Models
{
    public class RegistrosDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
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
