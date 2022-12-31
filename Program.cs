using System.Text;
using Sistema_de_resrvar_de_um_hotel.Models;






 List<Pessoa> hospedes = new List<Pessoa>();

 Pessoa p1 = new Pessoa (nome: "Hospede 1");
 Pessoa p2 = new Pessoa (nome: "Hospede 2");


 hospedes.Add(p1);
 hospedes.Add(p2);
 

 Suite suite = new Suite (tiposuite: "Premium", capacidade: 2, valordiaria: 50M);

 Reserva reserva = new Reserva(diasReservados: 10);
 reserva.CadastrarSuite(suite);
 reserva.CadastrarHospedes(hospedes);

 Console.WriteLine($"Hospede: {reserva.ObterQuantidadeHospedes()}");
 Console.WriteLine($"Hospede: {reserva.CalcularValorDiaria()}");