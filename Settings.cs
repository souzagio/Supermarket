using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Settings
    {
        private static Int16 _login = 0;
        public static Int16 login
        {
            get { return _login; }
            set { _login = value; }
        }
    }
}
