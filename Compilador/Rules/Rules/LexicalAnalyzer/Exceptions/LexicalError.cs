using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.LexicalAnalyzer.Exceptions
{
    public class LexicalError : AnalysisError
    {
        public LexicalError(string message, int position) : base(message, position)
        {
        }

        public LexicalError(string message) : base(message)
        {
        }
    }
}
