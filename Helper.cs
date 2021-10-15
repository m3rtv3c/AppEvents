using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvents
{
    class Helper
    {
        public static Model1Container s_model1Container;

        public static Model1Container GetContext()
        {
            if (s_model1Container == null)
            {
                s_model1Container = new Model1Container();
            }
            return s_model1Container;
        }
    }
}
