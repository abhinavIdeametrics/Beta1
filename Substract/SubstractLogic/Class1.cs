using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubstractLogic
{
    public interface ISubstract
    {
        double Substract(double x, double y);

        IEnumerable<string> CollecString { get; set; }
    }

    public class Substaction:ISubstract
    {
        public double Substract(double x, double y)
        {
            return x - y;
        }


        public IEnumerable<string> CollecString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Substaction()
        {
            CollecString = new List<string> {"Dan Brown"};
        }
    }


}
