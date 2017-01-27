using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectNLayer.BEntities;
using ProjectNLayer.Data;

namespace ProjectNLayer.BLogic
{
    public class DemoBL
    {
        public List<DemoBE> GetLstDemo()
        {
            var DA = new DemoDA();
            return DA.GetLstDemos();
        }
    }
}
