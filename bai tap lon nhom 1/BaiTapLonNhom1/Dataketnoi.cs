using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLonNhom1
{
    class Dataketnoi
    {
        string constr;
        public Dataketnoi()
        {
            constr = @"Data Source=LAPTOP-0M4SF6K4\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        }
        public SqlConnection getketnoi()
        {
            return new SqlConnection(constr);
        }

    }
}
