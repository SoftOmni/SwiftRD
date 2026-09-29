using JetBrains.Text;

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
    }
}