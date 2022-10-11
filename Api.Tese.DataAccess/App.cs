using Api.Tese.DataAccess.DataAccess.Mock;
using Api.Tese.DataAccess.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tese.DataAccess
{
    public class App
    {


        private static IDataAccess dataAccess;


        public static IDataAccess DataAccess
        {
            get
            {
                if(App.dataAccess == null)
                {
                    App.dataAccess = new SqlServerDataAccess(System.Configuration.ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
                }


                return App.dataAccess;
            }
        }
    }
}
