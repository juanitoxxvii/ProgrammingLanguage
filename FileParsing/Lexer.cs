using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguage {
    public class Lexer {

        private List<Token> tokensForLine = new List<Token>();

        internal List<Token> TokensForLine { get => this.tokensForLine; }


        public Lexer () { }

        public Lexer (string lineOfCode) {
            
        }

        private void ParseLineOfCode (string lineOfCode) {
            
        }
    }
}
