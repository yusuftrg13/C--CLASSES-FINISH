using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınheritence
{
    internal class Chef
    {


        public void MakeSalad()
        {
            Console.WriteLine("The Salad is preparing");
        }
        public void MakeKebap()
        {
            Console.WriteLine("Kebap is delicious");
        }

        public virtual void MakeSpecial()
        {
            Console.WriteLine("Special is coming");
        }
    }
}
