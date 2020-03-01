using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    public enum EstadoCredito
    {
        PENDIENTE =0,
        ACTIVO = 1,
        FINALIZADO = 2,
        PENDIENTEFINALIZACION = 3,
        MOROSO = 4
    }
}
