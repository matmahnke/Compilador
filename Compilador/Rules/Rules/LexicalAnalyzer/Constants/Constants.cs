using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.LexicalAnalyzer.Constants
{
    public abstract class Constants : ScannerConstants
    {
        public const int EPSILON = 0;
        public const int DOLLAR = 1;
        public const int t_identificador = 2;
        public const int t_constanteInteira = 3;
        public const int t_constanteReal = 4;
        public const int t_constanteString = 5;
        public const int t_constanteCaractere = 6;
        public const int t_bloco = 7;
        /// <summary>
        /// +
        /// </summary>
        public const int t_TOKEN_8 = 8;
        /// <summary>
        /// *
        /// </summary>
        public const int t_TOKEN_9 = 9;
        /// <summary>
        /// /
        /// </summary>
        public const int t_TOKEN_10 = 10;
        /// <summary>
        /// ?
        /// </summary>
        public const int t_TOKEN_11 = 11;
    }
}
