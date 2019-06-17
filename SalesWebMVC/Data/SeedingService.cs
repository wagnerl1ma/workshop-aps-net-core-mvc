using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()  //semente... popular
        {
            if (_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.RegistroDeVendas.Any())
            {
                return;  //DB já foi populado
            }

            Departamento d1 = new Departamento(1, "Computers");
            Departamento d2 = new Departamento(2, "Electronics");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Books");

            Vendedor v1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor v2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor v3 = new Vendedor(3, "Alex Gray", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor v4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor v5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor v6 = new Vendedor(6, "Alex Pink", "alexpink@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);


            RegistrosDeVendas r1 = new RegistrosDeVendas(1, new DateTime(2018, 9, 25), 1100.0, StatusVendas.Faturado, v1);
            RegistrosDeVendas r2 = new RegistrosDeVendas(2, new DateTime(2018, 09, 4), 7000.0, StatusVendas.Faturado, v5);
            RegistrosDeVendas r3 = new RegistrosDeVendas(3, new DateTime(2018, 09, 13), 4000.0, StatusVendas.Cancelado, v4);
            RegistrosDeVendas r4 = new RegistrosDeVendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVendas.Faturado, v1);
            RegistrosDeVendas r5 = new RegistrosDeVendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVendas.Faturado, v3);
            RegistrosDeVendas r6 = new RegistrosDeVendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVendas.Faturado, v1);
            RegistrosDeVendas r7 = new RegistrosDeVendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVendas.Faturado, v2);
            RegistrosDeVendas r8 = new RegistrosDeVendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVendas.Faturado, v4);
            RegistrosDeVendas r9 = new RegistrosDeVendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVendas.Pendente, v6);
            RegistrosDeVendas r10 = new RegistrosDeVendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVendas.Faturado, v6);
            RegistrosDeVendas r11 = new RegistrosDeVendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVendas.Faturado, v2);
            RegistrosDeVendas r12 = new RegistrosDeVendas(12, new DateTime(2018, 09, 25), 7000.0, StatusVendas.Pendente, v3);
            RegistrosDeVendas r13 = new RegistrosDeVendas(13, new DateTime(2018, 09, 29), 10000.0, StatusVendas.Faturado,v4 );
            RegistrosDeVendas r14 = new RegistrosDeVendas(14, new DateTime(2018, 09, 4), 3000.0, StatusVendas.Faturado, v5);
            RegistrosDeVendas r15 = new RegistrosDeVendas(15, new DateTime(2018, 09, 12), 4000.0, StatusVendas.Faturado, v1);
            RegistrosDeVendas r16 = new RegistrosDeVendas(16, new DateTime(2018, 10, 5), 2000.0, StatusVendas.Faturado, v4);
            RegistrosDeVendas r17 = new RegistrosDeVendas(17, new DateTime(2018, 10, 1), 12000.0, StatusVendas.Faturado, v1);
            RegistrosDeVendas r18 = new RegistrosDeVendas(18, new DateTime(2018, 10, 24), 6000.0, StatusVendas.Faturado, v3);
            RegistrosDeVendas r19 = new RegistrosDeVendas(19, new DateTime(2018, 10, 22), 8000.0, StatusVendas.Faturado, v5);
            RegistrosDeVendas r20 = new RegistrosDeVendas(20, new DateTime(2018, 10, 15), 8000.0, StatusVendas.Faturado, v6);
            RegistrosDeVendas r21 = new RegistrosDeVendas(21, new DateTime(2018, 10, 17), 9000.0, StatusVendas.Faturado, v2);
            RegistrosDeVendas r22 = new RegistrosDeVendas(22, new DateTime(2018, 10, 24), 4000.0, StatusVendas.Faturado, v4);
            RegistrosDeVendas r23 = new RegistrosDeVendas(23, new DateTime(2018, 10, 19), 11000.0, StatusVendas.Cancelado, v2);
            RegistrosDeVendas r24 = new RegistrosDeVendas(24, new DateTime(2018, 10, 12), 8000.0, StatusVendas.Faturado, v5);
            RegistrosDeVendas r25 = new RegistrosDeVendas(25, new DateTime(2018, 10, 31), 7000.0, StatusVendas.Faturado, v3);
            RegistrosDeVendas r26 = new RegistrosDeVendas(26, new DateTime(2018, 10, 6), 5000.0, StatusVendas.Faturado, v4);
            RegistrosDeVendas r27 = new RegistrosDeVendas(27, new DateTime(2018, 10, 13), 9000.0, StatusVendas.Pendente, v1);
            RegistrosDeVendas r28 = new RegistrosDeVendas(28, new DateTime(2018, 10, 7), 4000.0, StatusVendas.Faturado, v3);
            RegistrosDeVendas r29 = new RegistrosDeVendas(29, new DateTime(2018, 10, 23), 12000.0, StatusVendas.Faturado, v5);
            RegistrosDeVendas r30 = new RegistrosDeVendas(30, new DateTime(2018, 10, 12), 5000.0, StatusVendas.Faturado, v2);

            
            //add os registros no banco de dados
            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);    // AddRange, add varios registros de uma só vez

            _context.RegistroDeVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12,
                                               r13, r14, r15, r16, r17, r18, r19, r20, r21, r22,
                                               r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges(); // salvar e confirmar as alterações no banco de dados
        }
    }
}
