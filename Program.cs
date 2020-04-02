using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
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
 * <stmt> -> id = <term>
 * <expr> → <term> {(+ | -) <term>}
 * <term> → <factor> {(* | /) <factor>}
 * <factor> → id | int_constant | ( <expr> )
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
    
    // global variables
    public static class Globals
    {
        public static int CharClass;
        public static char[] Lexeme = new char[100];
        public static char NextChar;
        public static int LexLength;
        public static int NextToken = -2;

        public static void Error(string msg)
        {
            Console.WriteLine(msg);
            Environment.Exit(1); // should be an error
        }
    }

    public static class Constants
    {
        public const int IntLiteral = 10;
        public const int Identifier = 11;
        public const int AssignOperator = 20;
        public const int AddOperator = 21;
        public const int SubOperator = 22;
        public const int MultOperator = 23;
        public const int DivOperator = 24;
        public const int LeftParen = 25;
        public const int RightParen = 26;
        
        // character classes
        public const int Letter = 0;
        public const int Digit = 0;
        public const int Unknown = 99;
    }
    
    
    
    // main program class
    class Program
    {
        public void AddChar()
        {
            if (Globals.LexLength <= 98)
            {
                Globals.Lexeme[Globals.LexLength++] = Globals.NextChar;
                Globals.Lexeme[Globals.LexLength] = (char) 0; // have to convert it to a char
            }
            else
            {
                
            }
        }

        public void GetChar()
        {
            
        }

        public void GetNonBlank()
        {
            
        }

        int Lookup(char ch)
        {
            return 0;
        }

        public int Lex()
        {
            return 0;
        }
        static void Main(string[] args)
        {
            string example = "a = 9";
            Globals.Error("this is an example.");

            Console.WriteLine("you shouldn't see me");
        }
    }
}