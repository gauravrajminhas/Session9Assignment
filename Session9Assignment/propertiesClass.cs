using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace Session9Assignment
{
    public class propertiesClass
    {
        public propertiesClass()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        private double _adjustedRates;
        // to protect my Rates variable i use  a propertys field; 


        // so properties are just getters and setters ! 
        public double rates
        {
            get { return _adjustedRates; }
            set { _adjustedRates = value + 0.25; }

        }
         

    }



}
