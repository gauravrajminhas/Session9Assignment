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


    public class immuatableClass
    {
        private string _exchnage="VISA";
        private string[] _SWIFTIntermediateries;

        public String exchnage 
        {
            set { _exchnage = "Master Card"; }
            get { return _exchnage; }

        }



    }

    public class immuatableClassConstructor
    {
        private string _exchnage;
        private string[] _SWIFTIntermediateries;
    }



}
