using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.LexicalAnalyzer.Exceptions
{
    public class SemanticError : AnalysisError
    {
        public SemanticError(string message, int position) : base(message, position)
        {
        }

        public SemanticError(string message) : base(message)
        {
        }
    }
}
