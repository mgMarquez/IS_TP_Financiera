using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class Plan
    {
        #region Properties
        public int numeroPlan { get; set; }
        public string descripcion { get; set; }
        public int cantidadCuotas { get; set; }
        public double porcentajeMensual { get; set; }
        #endregion


    }
}
