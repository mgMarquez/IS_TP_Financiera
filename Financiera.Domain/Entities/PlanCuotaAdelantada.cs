using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class PlanCuotaAdelantada : Plan
    {
        #region Constructors
        public PlanCuotaAdelantada(int numeroPlan, string descripcion, int cantidadCuotas, double porcentajeMensual) : base(numeroPlan, descripcion, cantidadCuotas, porcentajeMensual)
        {

        }
        #endregion
    }
}
