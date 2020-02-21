using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
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
    // token class
    class Token
    {
        // this class merely represents a token
        
        public int Value;
        public string Type;
        
        public Token(string type, int value)
        {
            // for now, we are going to leave value as an int, but it should be able to accept any type of variable
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
            
            // split the code by the space -> consume all the space in between
            string[] splited = Regex.Split(code, @"\s+"); 
            
            // print
            foreach (var token in splited)
            {
                Console.WriteLine(token);
            }
        }
    }
}