using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Entities
{
    enum EstadoCredito
    {
        PENDIENTE =1,
        ACTIVO = 2,
        FINALIZADO = 3,
        PENDIENTEFINALIZACION = 4,
        MOROSO = 5
    }
}
