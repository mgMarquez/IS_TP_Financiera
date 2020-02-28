using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class Cuota
    {
        #region Properties
        public int numeroCuota { get; set; }
        public double importeCuota { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public double saldoActual { get; set; }
        #endregion

    }
}
