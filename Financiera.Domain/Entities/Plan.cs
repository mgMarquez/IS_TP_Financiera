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

        #region Constructor
        public Plan(int numeroPlan, string descripcion, int cantidadCuotas, double porcentajeMensual)
        {
            this.numeroPlan = numeroPlan;
            this.descripcion = descripcion;
            this.cantidadCuotas = cantidadCuotas;
            this.porcentajeMensual = porcentajeMensual;
        }

        #endregion

        #region Public Methods
        public double calcularInteresTotal()
        {

            throw new NotImplementedException();
        }
        #endregion
    }
}
