using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    public class Token
    {
        private int Id { get; set; }
        private string Lexeme { get; set; }
        private int Position { get; set; }

        public Token(int id, string lexeme, int position)
        {
            this.Id = id;
            this.Lexeme = lexeme;
            this.Position = position;
        }

        public override string ToString()
        {
            return string.Format("{0} ( {1} ) @ {2}", Id, Lexeme, Position);
        }
    }
}