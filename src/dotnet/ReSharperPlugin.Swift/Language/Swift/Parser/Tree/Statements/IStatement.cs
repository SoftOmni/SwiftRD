using System;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

public interface IStatement : ISwiftNode
{
    public bool CanHaveMultipleOnOneLineSeparatedBySemicolons { get; }

    public static class Parser
    {
        internal static IStatement ParseWithStart(SwiftLexer lexer, IEditableBuffer parentBuffer, int offset)
        {
            throw new NotImplementedException();
        }
    }
}