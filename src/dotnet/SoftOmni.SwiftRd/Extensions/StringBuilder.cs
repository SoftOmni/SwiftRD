using System.Text;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Extensions;

public static class StringBuilderExtensions
{
    public static StringBuilder Append(this StringBuilder builder, IBuffer buffer)
    {
        for (int i = 0; i < buffer.Length; i++)
        {
            builder.Append(buffer[i]);
        }

        return builder;
    }
}