using System;
using System.Collections.Generic;
using System.Linq;
using SubstractLogic;
using System.Web;

namespace Substract.Model
{
    public class MyModel
    {
        public string MyName { get; set; }

        public ISubstract substract;
        public MyModel(ISubstract _substract)
        {
            substract = _substract;
        }
    }
}