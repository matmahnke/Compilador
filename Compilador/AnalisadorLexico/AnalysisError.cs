using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    public class AnalysisError : Exception
    {
        private int Position { get; set; }

        public AnalysisError(string msg, int position) : base(msg)
        {
            this.Position = position;
        }

        public AnalysisError(string msg) : base(msg) 
        {
            this.Position = -1;
        }

        public override string ToString()
        {
            return base.ToString() + ", @ " + Position;
        }
    }
}