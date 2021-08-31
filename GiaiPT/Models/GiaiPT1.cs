using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiaiPT.Models
{
    public class GiaiPT1
    {
        public double GiaiPT(float a, float b)
        {
            float nghiem = 0f;
            nghiem = -b / a;

            return nghiem;

        }
    }
}