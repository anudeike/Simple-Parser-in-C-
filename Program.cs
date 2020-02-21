using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

/*
 * CALCULATOR PROGRAM
 * this handles simple operations such as 3 + 6
 *
 * Grammar ->
 * 
 * expr: INTEGER OP INTEGER EOF
 */

namespace SimpleTokenizer
{
    class Tokenizer
    {
        public List<Token> tokens;

        public Tokenizer(string raw_text)
        {
            this.tokens = GenerateTokenList(raw_text);
        }
        
        // generate the token list
        private List<Token> GenerateTokenList(string text)
        {
            // create a temp list to hold the tokens
            List<Token> t = new List<Token>();
            
            // list of possible operators
            string[] operators = {"+", "-", "*", "/"};
            // for each token in the Regex Split
            foreach (var symbol in Regex.Split(text,@"\s+"))
            {
                string type = "";
                
                // if it matches a digit
                if (Regex.IsMatch(symbol, @"\d+"))
                {
                    type = "INTEGER";
                }
                
                // if it matches an operation
                if (operators.Contains(symbol))
                {
                    type = "OP";
                }
                
                // add to the token list
                t.Add(new Token(type, symbol));
                // go thru the cases to check what type of variable is coming
                Console.WriteLine(symbol + " " + type);
            }
            return null;
        }
    }
    // token class
    class Token
    {
        // this class merely represents a token
        
        public string Value;
        public string Type;
        
        public Token(string type, string value)
        {
            // make them both come in a strings
            this.Type = type;
            this.Value = value;
        }

        public override string ToString()
        {
            // give a string representation of the class
            return $"TOKEN: ({Type}, {Value})";
        }
    }

    class Interpreter
    {
        public string Text;
        public int Pos;
        public Token Current_Token; // this should start out empty and will be created
        
        // this is the main intepreter class
        public Interpreter(string text)
        {
            // string input
            this.Text = text;
            
            //set the pos to 0 and set the current token to null
            this.Pos = 0;
            this.Current_Token = null;
        }
        
        // will implement better error handling later
        public string ThrowError()
        {
            return "Error parsing.";
        }
        
        // get the next token
        public Token GetToken()
        {
            
            // returns the next token
            return null;
        }
        
    }
    // main program class
    class Program
    {
        static void Main(string[] args)
        {
            // source code that we will test
            string code = "3 + 4";

            // push thru the tokenizer
            Tokenizer tk = new Tokenizer(code);
        }
    }
}