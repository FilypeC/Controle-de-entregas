using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_entregas.Classes
{
    public class Entrega
    {
        public int Cli { get; set; }
        public Double Saida { get; set; }
        public Double Nota { get; set; }
        public int Quantidade { get; set; }
        public DateTime Dia { get; set; }
    }
}
