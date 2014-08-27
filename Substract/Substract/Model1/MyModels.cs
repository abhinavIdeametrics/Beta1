using System;
using System.Collections.Generic;
using System.Linq;
using SubstractLogic;
using System.Web;

namespace Substract.Model1
{
    public class MyModels
    {
        public ISubstract _substract;


        public MyModels(ISubstract substract)
        {
            _substract = substract;
        }
    }
}