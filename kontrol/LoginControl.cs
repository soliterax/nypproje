using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypproje
{
    public class LoginControl
    {
        
        static LoginType typeName;

        public static void typeYaz(LoginType type)
        {
            typeName = type;
        }

        public static LoginType typeOku()
        {
            return typeName;
        }

        public enum LoginType
        {
            Admin, Moderator, Worker
        }
    }
}
