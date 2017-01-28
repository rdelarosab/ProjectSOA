using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNLayer.BEntities
{
    public class OrdenDetalleBE
    {
        public int OrdenDetalleId { get; set; }
        public ProductoBE Producto { get; set; } = new ProductoBE();
        public int OrdenDetalleCantidad { get; set; }
    }
}
