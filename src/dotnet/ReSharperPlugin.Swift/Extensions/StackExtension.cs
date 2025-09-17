using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Extensions;

public static class StackExtension
{
    public static bool IsEmpty<TElement>(this Stack<TElement> stack)
    {
        return stack.Count == 0;
    }
}