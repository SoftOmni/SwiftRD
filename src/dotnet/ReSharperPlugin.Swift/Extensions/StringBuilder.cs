using System.Text;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Extensions;

public static class StringBuilderExtensions
{
    extension(StringBuilder builder)
    {
        public StringBuilder Append(IBuffer buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                builder.Append(buffer[i]);
            }

            return builder;
        }
    }
}