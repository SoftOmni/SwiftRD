using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language;

public class Tests
{
    public static void Main()
    {
        string testCode = """
                          #include <stdio.h>
                          
                          int main() {
                              @autoreleasepool {
                              
                              }
                              puts("Hello World!");
                              return 0;
                          }
                          """;
        IBuffer buffer = new StringBuffer(testCode);
    }
}
