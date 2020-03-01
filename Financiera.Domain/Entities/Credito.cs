using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class Credito
    {
        #region Properties
        public int numeroCredito { get; set; }
        public double monto { get; set; }
        public double interes { get; set; }
        public DateTime fechaCreacion { get; set; }
        public Empleado empleado { get; set; }
        public EstadoCredito estadoCredito { get; set; }
        public Plan plan { get; set; }
        public List<Cuota> cuotas { get; set; }


        #endregion

        #region Constructors

        #endregion

        #region Public Methods

        #endregion
    }
}
