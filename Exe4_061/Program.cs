﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_061
{
   class Stacks
   {
        public int[] element;
        public int top;
        public int max;

        public Stacks(int size)
        {
            element = new int[size];
            top = -1;
            max = size;
        }

        bool empty()
        {
            if (top == -1)
                return(true);
            else
                return(false);
        }

        
    }
}