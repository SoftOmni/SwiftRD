using System;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

public interface IStatement : ISwiftNode
{
    public bool CanHaveMultipleOnOneLineSeparatedBySemicolons { get; }

    public static class Parser
    {
        internal static IStatement ParseWithStart(SwiftLexer lexer, IEditableBuffer parentBuffer, int offset)
        {
            
        }
    }
}