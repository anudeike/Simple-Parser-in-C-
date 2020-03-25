using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mime;
using System.Runtime.CompilerServices;

/*
 * CALCULATOR PROGRAM
 * this handles simple operations such as 3 + 6
 *
 * Grammar ->
 * ASSIGNMENT ::= LHS '=' RHS
 * LHS = IDENTIFIER
 * RHS = IDENTIFIER | NUMBER
 * 
 */

namespace SimpleTokenizer
{
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
    class Tokenizer
    {
        public List<Token> tokens;
        public List<Token> processed_tokens;
        
        public int pos;
        
        public Tokenizer(string raw_text)
        {
            this.tokens = GenerateTokenUsingSplit(raw_text);
            this.pos = 0;
        }
        
        private List<Token> GenerateTokenUsingSplit(string text)
        {
            // take in the string and use the match function to match function to create a token
            string[] tks = text.Split(new char[] {' ', ';'});
            
            // create a temp list to hold the tokens
            List<Token> t = new List<Token>();
            
            // for each token, match it
            foreach (string word in tks)
            {
                t.Add(Match(word));
            }
            
            // add the EOF token
            t.Add(new Token("EOF", "EOF"));

            return t;
        }

        private Token Match(string unMatchedToken)
        {

            // if it matches a digit
            if (Regex.IsMatch(unMatchedToken, @"\d+"))
            {
                // return the token
                Console.WriteLine(unMatchedToken + " INTEGER");
                return new Token("INTEGER", unMatchedToken);
            }
                
            // if it matches a word
            if (Regex.IsMatch(unMatchedToken, @"\w+"))
            {
                // return the token
                Console.WriteLine(unMatchedToken + " IDENTIFIER");
                return new Token("IDENTIFIER", unMatchedToken);
            }

            // if it matches an equal sign
            if (unMatchedToken.Equals("="))
            {
                // return the token
                Console.WriteLine(unMatchedToken + " EQUAL_SIGN");
                return new Token("INTEGER", unMatchedToken);
            }
            
            if (unMatchedToken.Equals("\n"))
            {
                // return the token
                Console.WriteLine(unMatchedToken + " NEWLINE");
                return new Token("NEWLINE", unMatchedToken);
            }
            
            // else it is an unknown token and should throw error
            return null;
        }

        public Token GetToken()
        {
            // returns the next token, moving up one in position
            return null;
        }

        public int Mark()
        {
            // returns the position of the array 
            return this.pos;
        }

        public void Reset(int p)
        {
            // sets the pos in list
            this.pos = p;
        }

        public Token Peek()
        {
            if (this.pos == this.processed_tokens.Count)
            {
                
            }
            
            // // returns the next token in list w/o changing the pos
            // if (this.pos == this.tokens.Count)
            // {
            //     // stub will continue later.
            // }
            return null;
        }
        
    }

    class Parser
    { 
        /*
        * Grammar ->
        * ASSIGNMENT ::= LHS '=' RHS
        * LHS = IDENTIFIER
        * RHS = IDENTIFIER | NUMBER
        *
        */
        
        private Tokenizer _tk;
        private Token _nextToken;
        public Parser(Tokenizer tk)
        {
            this._tk = tk;
            
            //do while to lex()
            do
            {
                tk.GetToken();
            } while (_nextToken.Type != "EOF");
        }

        private void ParseAssignment()
        {
            
        }
        
        // 
        
    }
    
    
    // main program class
    class Program
    {
        static void Main(string[] args)
        {
            string example = "a = 9";
            
            // tokenize
            Tokenizer tk = new Tokenizer(example);
        }
    }
}