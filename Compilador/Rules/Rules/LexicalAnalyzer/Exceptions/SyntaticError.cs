using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.LexicalAnalyzer.Exceptions
{
    public class SyntaticError : AnalysisError
    {
        public SyntaticError(string message, int position) : base(message, position)
        {
        }

        public SyntaticError(string message) : base(message)
        {
        }
    }
}
