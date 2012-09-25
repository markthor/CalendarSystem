using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarSystem
{
    class Model
    {
        private static Model instance = new Model();

        private Model() { }

        public static Model Instance
        {
            get;
        }

    }
}
