﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServices
{
    public class MathService : IMathService
    {
        public Int32 Add(Int32 piNum1, int piNum2)
        {
            return piNum1 + piNum2;
        }
        public Int32 Subtract(Int32 piNum1, int piNum2)
        {
            return piNum1 - piNum2;
        }
        public Int32 Multiply(Int32 piNum1, int piNum2)
        {
            return piNum1 * piNum2;
        }
        public Int32 Divide(Int32 piNum1, int piNum2)
        {
            return piNum1 / piNum2;
        }

    }
}
