﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Interfaces
{
    public interface ITax
    {
        double GetTaxByState(char state);
   
    }
}
