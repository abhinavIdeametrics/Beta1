﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubstractLogic
{
    public interface ISubstract
    {
        double Substract(double x, double y);
        //Trial Edit
       IEnumerable<string> CollecString { get; set; }
    }

    public class Substaction:ISubstract
    {
        public double Substract(double x, double y)
        {
            return x - y;
        }

        private IEnumerable<string> collectionString;

        public IEnumerable<string> CollecString
        {
           

            get
            {
             return collectionString;
            }
            set
            {
                collectionString = value;
            }
        }

        public Substaction()
        {
            collectionString = new List<string> {"Dan Brown"};
        }
    }


}
