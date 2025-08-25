using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Net2025_Banque
{
    public class DemoDelegate
    {

        List<int> ints = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,
        };

        public List<int> filter(Func<int,bool> predicate)
        {
            List<int> result = new List<int>();
            foreach (int i in ints) 
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
