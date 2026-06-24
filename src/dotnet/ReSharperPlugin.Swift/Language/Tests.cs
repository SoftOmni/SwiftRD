using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

namespace SoftOmni.SwiftRd.Language;

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