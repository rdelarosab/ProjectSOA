using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNLayer.BEntities
{
    public class OrdenBE
    {
        public int OrdenId { get; set; }
        public DateTime OrdenFecha { get; set; }
        public ClienteBE Cliente { get; set; } = new ClienteBE();
        public List<OrdenDetalleBE> LstOrdenDetalle { get; set; } = new List<OrdenDetalleBE>();
    }
}
