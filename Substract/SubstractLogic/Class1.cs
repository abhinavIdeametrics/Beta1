using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubstractLogic
{
    public interface ISubstract
    {
        double Substract(double x, double y);
    }

    public class Substaction:ISubstract
    {
        public double Substract(double x, double y)
        {
            return x - y;
        }
    }


}
