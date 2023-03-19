using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Context
{
    public class PoliceContext
    {
      
        public int Id { get; set; }
        public double LimitMin { get; set; }
        public double LimitMax { get; set; }
        public int Percent { get; set; }
        public string Formula { get; set; }

    
    }
}
