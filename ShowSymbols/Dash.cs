using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowSymbols
{
    class Dash
    {
        public int dashCount;
        public int dashCountHelper;
        public int dashCountHelper2;
        public Dash()
        {

        }
        public void CreateDashes(int dashCount)
        {
            for (int a = 0; a < dashCount; a++)
            {
                Console.Write("-");
            }
        }
        public void SetDashCount(int value)
        {
            dashCount = value;
        }
        public void SetDashCountHelper(int value)
        {
            dashCountHelper = value;
        }
        public void SetDashCountHelper2(int value)
        {
            dashCountHelper2 = value;
        }
    }
}
