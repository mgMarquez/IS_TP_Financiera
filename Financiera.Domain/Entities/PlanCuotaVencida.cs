using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class PlanCuotaVencida : Plan
    {
        #region Properties
        public string porcentajeGastoAdministrativo { get; set; }
        #endregion

        #region Constructors
        public PlanCuotaVencida(int numeroPlan, string descripcion, int cantidadCuotas, double porcentajeMensual, string porcentajeGastoAdministrativo) : base(numeroPlan, descripcion, cantidadCuotas, porcentajeMensual)
        {
            this.porcentajeGastoAdministrativo = porcentajeGastoAdministrativo;
        }
        #endregion
    }
}
