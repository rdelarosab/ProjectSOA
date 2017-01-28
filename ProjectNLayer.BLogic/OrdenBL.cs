using ProjectNLayer.BEntities;
using ProjectNLayer.Data;

namespace ProjectNLayer.BLogic
{
    public class OrdenBL
    {
        private OrdenDA ordenDA;

        public OrdenBL()
        {
            ordenDA = new OrdenDA();
        }

        public OrdenBE GetOrdenById()
        {
            return ordenDA.GetOrdenById();
        }
    }
}
