using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

public class LineControlStatement : CompilerControlStatement
{
    public Identifier? SourceLocation { get; internal set; }
    
    public IntegerLiteral? LineNumber { get; internal set; }
    
    public StringLiteral? StaticStringLiteral { get; internal set; }

    public LineControlStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public LineControlStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public LineControlStatement(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public LineControlStatement(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}