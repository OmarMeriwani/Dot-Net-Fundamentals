using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;

namespace MVC_Fundamentals.Repository
{
    public class StatusRepository
    {
        OracleConnection con = new OracleConnection("DATA SOURCE=OLTP2;PASSWORD=Shortcode;USER ID=Shortcode");
        public List<Models.Status2> statusList()
        {
            List<Models.Status2> stl = new List<Models.Status2>();
            OracleCommand oCommand = new OracleCommand("select * from tbl_status_sc",con);
            con.Open();
            OracleDataReader reader = oCommand.ExecuteReader();
            while (reader.Read()) {
                Models.Status2 st = new Models.Status2();
                st.ST_ID = Convert.ToInt32( reader["ST_ID"]);
                st.ST_NAME = reader["ST_NAME"].String;
            }



            return stl;
        }
    
    }

    
}