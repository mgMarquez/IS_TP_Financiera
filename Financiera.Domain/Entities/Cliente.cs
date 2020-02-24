using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public class Cliente
    {
        #region Properties
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public double sueldo { get; set; }
        #endregion

        #region Constructors
        public Cliente()
        {

        }
        #endregion

        #region Public Methods
        public void MyMethod()
        {

        }
        #endregion        
    }
}
