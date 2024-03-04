using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Gyumolcs_7
{
   public static class ExtMethods
    {
        public static int GetUnitPrice(this Button bt)
        {
            return int.TryParse(bt.Text, out int UnitPrice) ? UnitPrice : 0;
        }
        public static void SetUnitPrice(this Button bt, int UnitPrice)
        {
            bt.Text = UnitPrice.ToString();
        }
    }
}
