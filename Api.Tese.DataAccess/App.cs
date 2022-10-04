using Api.Tese.DataAccess.DataAccess.Mock;
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
                    App.dataAccess = new MockDataAccess();
                }


                return App.dataAccess;
            }
        }
    }
}
