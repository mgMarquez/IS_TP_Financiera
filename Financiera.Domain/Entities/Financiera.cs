using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class Financiera
    {
        #region Properties
        public int codFinanciera { get; set; }
        public string razonSocial { get; set; }
        public string nombreFantasia { get; set; }
        public string domicilio { get; set; }
        public int cuit { get; set; }
        public double montoMaximo { get; set; }
        public int cantCreditoMax { get; set; }
        public double porcentajeDiario { get; set; }
        public int maxCuotaVencimiento { get; set; }
        public List<Empleado> listaEmpleados { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Public Methods

        #endregion
    }
}
