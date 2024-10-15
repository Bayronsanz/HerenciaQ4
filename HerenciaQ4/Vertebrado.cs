using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaQ4
{
    public class Vertebrado :Animal{
        public string TipoEsqueleto { get; set; }
        public int NumeroExtremidades { get; set; }
        public string TipoSangre { get; set; }
        public string Dieta { get; set; }
        public int ExpectaticaVida { get; set;}
        public string Reproduccion { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Habitad: {Habitad}");
            Console.WriteLine($"Tipo de esqueleto: {TipoEsqueleto}");
            Console.WriteLine($"Numero de extremidades: {TipoSangre}");
            Console.WriteLine($"Dieta: {Dieta}");
            Console.WriteLine($"Expectativa de Vida: {ExpectaticaVida}");
            Console.WriteLine($"Reproducción: {Reproduccion}");

        }
    }
}
