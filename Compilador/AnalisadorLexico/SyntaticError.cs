using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    public class SyntaticError : AnalysisError
    {
        public SyntaticError(string msg, int position)
        {
            base(msg, position);
        }

        public SyntaticError(string msg)
        {
            base(msg);
        }
    }
}