using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Parsing;
using JetBrains.ReSharper.Psi.CSharp.Util.Literals.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

public abstract class SwiftTokenNodeType : TokenNodeType
{
    protected SwiftTokenNodeType(string name, int index)
        : base(name, index)
    {
        SwiftNodeTypeIndexer.Instance.Add(this, index);
    }

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new InvalidOperationException();
    }

    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;
    
    public virtual bool ExpressionAndTypeUsable => false;
}