using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlarz_4a
{
   public static class User
    {
        public static int Id;
        public static String username;
        public static float cash;

        public static void Reset()
        {

            User.Id = 0;
            User.username = "";
            User.cash = 0.0f;
        }  

    }


}
