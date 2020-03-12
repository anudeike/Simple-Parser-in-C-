using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.CompilerServices;

/*
 * CALCULATOR PROGRAM
 * this handles simple operations such as 3 + 6
 *
 * Grammar ->
 * GOAL ::= ASSIGNMENT
 * ASSIGNMENT ::= LHS '=' RHS
 * LHS = IDENTIFIER
 * RHS = IDENTIFIER | NUMBER
 * 
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
                    // add to the token list
                    t.Add(new Token(type, symbol));
                    
                    // go thru the cases to check what type of variable is coming
                    Console.WriteLine(symbol + " " + type);
                    
                    continue;
                }
                
                // if it matches a word
                if (Regex.IsMatch(symbol, @"\w+"))
                {
                    type = "IDENTIFIER";
                    
                    // add to the token list
                    t.Add(new Token(type, symbol));
                    
                    // go thru the cases to check what type of variable is coming
                    Console.WriteLine(symbol + " " + type);
                    continue;
                }

                // if it matches an equal sign
                if (symbol.Equals("="))
                {
                    type = "EQUALS_SIGN";
                    
                    // add to the token list
                    t.Add(new Token(type, symbol));
                    
                    // go thru the cases to check what type of variable is coming
                    Console.WriteLine(symbol + " " + type);
                    continue;
                }
                
                
            }
            
            // end an eof token to the end -> will use the new line character for the time being
            t.Add(new Token("EOF", "\n")); 
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

    class Parser
    {
        public List<Token> tokens;
        
        public Parser(List<Token> tks)
        {
            this.tokens = tks;
        }

        public bool ParseTokens()
        {
            foreach (var tk in tokens)
            {
                
            }
            return false;
        }
        public void ThrowError(string type)
        {
            // crude but will be improved on later
            if (type.Equals("syntax"))
            {
                Console.WriteLine("SYNTAX ERROR");
            }
        }
        
        // list of parsing functions
        public bool Parse_Goal()
        {
            return false;
        }
        
        public bool Parse_Assignment()
        {
            return false;
        }
        
        public bool Parse_LHS()
        {
            return false;
        }
        
        public bool Parse_RHS(Token tk)
        {
            // according to the grammar given
            if (Parse_Identifer(tk))
            {
                
            }
            
            return false;
        }
        
        // TERMINALS
        public bool Parse_Equals(Token tk)
        {
            if (tk.Type.Equals("IDENTIFIER"))
            {
                Console.WriteLine("\nFound Identifier: ");
                return true;
            }
            
            return false;
        }
        
        public bool Parse_Identifer(Token tk)
        {
            if (tk.Type.Equals("IDENTIFIER"))
            {
                Console.WriteLine("\nFound Identifier: ");
                return true;
            }
            
            return false;
        }
        
        public bool Parse_Integer(Token tk)
        {
            // test input to see if it is an integer
            // this is a terminal, so you only need to test if it is what it is
            if (tk.Type.Equals("INTEGER"))
            {
                Console.WriteLine("\nFound Integer: ");
                return true;
            }
            
            return false;
        }
        
    }
    // main program class
    class Program
    {
        static void Main(string[] args)
        {
            // source code that we will test
            string code = "a = 9";

            // push thru the tokenizer
            Tokenizer tk = new Tokenizer(code);
        }
    }
}