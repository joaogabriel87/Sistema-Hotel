using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_resrvar_de_um_hotel.Models
{
    public class Reserva
    {
       public List<Pessoa> Hospedes {get; set;}
       public Suite Suite {get; set;} 
       public int DiasReservados { get; set; }

       public Reserva(){}

       public Reserva(int diasReservados)
       {
        DiasReservados = diasReservados;
       }

       public void CadastrarHospedes(List<Pessoa> hospedes)
       {
        
        
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Numero de hóspede superior a capacidade");
        }
       }

       public void CadastrarSuite(Suite suite)
       {
        Suite = suite;
       }

       public int ObterQuantidadeHospedes()
       {
        return Hospedes.Count;
       }

       public decimal CalcularValorDiaria()
       {
        decimal valor =  DiasReservados * Suite.ValorDiaria;
        decimal porce = 10;

        if (DiasReservados >= 10)
        {
            valor = valor - (valor / porce);
        }
          return valor;
       }
    }
}