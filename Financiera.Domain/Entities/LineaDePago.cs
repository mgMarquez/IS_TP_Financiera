using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class LineaDePago
    {
        #region Properties
        public double monto { get; set; }
        public Cuota cuota { get; set; }
        #endregion
    }
}
