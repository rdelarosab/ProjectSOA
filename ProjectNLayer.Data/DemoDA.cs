using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectNLayer.BEntities;

namespace ProjectNLayer.Data
{
    public class DemoDA
    {
        SqlConnection cn = Connection.GetConnection();

        public List<DemoBE> GetLstDemos()
        {
            var lstDemo = new List<DemoBE>();
            try
            {
                var cmd = new SqlCommand("SELECT DemoId, DemoName FROM DEMO", cn);
                cmd.CommandType = CommandType.Text;              
                SqlDataReader dr = null;                
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var demo = new DemoBE
                    {
                        DemoId = Convert.ToInt32(dr["DemoId"]),
                        DemoName = dr["DemoName"].ToString()
                    };                   
                    lstDemo.Add(demo);
                }
                cn.Close();
            }
            catch (Exception)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    return null;
                }
            }
            return lstDemo;
        }
    }
}
