using System;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer;

namespace ReSharperPlugin.Swift.Language;

public class Tests
{
    public static void Main()
    {
        string testCode = """
                          import Foundation
                          
                          func main() {
                              println("Hello, world!")
                          }
                          """;
        IBuffer buffer = new StringBuffer(testCode);
        SwiftLexer swiftLexer = new(buffer);
    }
}