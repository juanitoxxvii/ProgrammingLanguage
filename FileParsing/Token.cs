using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguage {

    internal class Token {
        internal enum Type {
            Identifier,
            Number,
            Operation,
            DataType,
        }

        private readonly Type type;
        private readonly string value;

        internal Type TokenType { get => this.type; }

        internal string Value { get => this.value; }

        internal Token (Type type, string value) {
            this.type = type;
            this.value = value;
        }

        public override string ToString () {
            return TokenType switch {
                Type.Identifier => $"[id: \"{Value}\"]",
                Type.Number => $"[num: {Value}]",
                Type.Operation => $"[op: '{Value}']",
                Type.DataType => $"[dt: \"{Value}\"]",
                _ => "Invalid token"
            };
        }
    }
}
