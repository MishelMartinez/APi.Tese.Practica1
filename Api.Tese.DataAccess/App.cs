using Api.Tese.DataAccess.DataAccess.Mock;
using Api.Tese.DataAccess.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
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
                    App.dataAccess = new SqlServerDataAccess("Server=baseapi.database.windows.net; DataBase=School; User ID=api; Password=Passw0rd123.");
                }


                return App.dataAccess;
            }
        }
    }
}
