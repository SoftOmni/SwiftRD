using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Extensions;

public static class StackExtension
{
    public static bool IsEmpty<TElement>(this Stack<TElement> stack)
    {
        return stack.Count == 0;
    }
}