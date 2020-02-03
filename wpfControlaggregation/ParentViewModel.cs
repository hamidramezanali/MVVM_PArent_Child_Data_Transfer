using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfControlaggregation
{
    public class ParentViewModel
    {
        public string myMainString { get; set; }
        public string myfirstString { get; set; }
        public string mySecondString { get; set; }
        public string mylaststring { get; set; }
        public ParentViewModel()
        {
            myMainString = "Main View";
            myfirstString = "First View";
            mySecondString = "Second View";
            mylaststring = "String from parent viewmodel to child viewmodel";
        }

      
    }
}
