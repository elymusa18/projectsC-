using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FRMLPStudentSuccess.GUI
{
    public class DataPoint
    { // Vhodni harakteristiki
        public double[] Features { get; set; }

        // Etiket: 1 = vzet izpit, 0 = nevzet
        public int Label { get; set; }
         
        public DataPoint(double[] features, int label)
        {
            Features = features;
            Label = label;
        }
    }
}
