using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarSystem
{
    class DBConnector
    {
        private static DBConnector instance;

        private DBConnector(){ }

        public static DBConnector Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBConnector();
                }
                return instance;
            }
        }
    }
}
