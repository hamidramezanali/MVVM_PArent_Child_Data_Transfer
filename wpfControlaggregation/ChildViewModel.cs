using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfControlaggregation
{
    public class ChildViewModel 
    {
        public string mySecondString { get; set; }
        public ChildViewModel()
        {
            mySecondString = "Second View from child";
        }
        public ChildViewModel(string mystring)
        {
            mySecondString = mystring;
        }
    }
}
