using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks.Clauses;

public class DidSetClause : SwiftCompositeNode, IDidSetClause
{
    public IAttributeGroup? Attributes { get; }

    public DidSet DidSet { get; }

    public LeftParenthesis? SetterNameStart { get; }

    public IIdentifier? SetterName { get; }

    public RightParenthesis? SetterNameEnd { get; }

    public ICodeBlock CodeBlock { get; }

    internal DidSetClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, DidSet didSet,
        LeftParenthesis? setterNameStart, IIdentifier? setterName,
        RightParenthesis? setterNameEnd, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DidSet = didSet;
        CodeBlock = codeBlock;
        SetterNameStart = setterNameStart;
        SetterName = setterName;
        SetterNameEnd = setterNameEnd;
    }

    IReadOnlyAttributeGroup? IReadOnlyDidSetClause.Attributes => Attributes;

    IReadOnlyCodeBlock IReadOnlyDidSetClause.CodeBlock => CodeBlock;

    IReadOnlyIdentifier? IReadOnlyDidSetClause.SetterName => SetterName;

    public void SetAttributeGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributeGroup()
    {
        throw new NotImplementedException();
    }

    public void SetSetterNameTo(IIdentifier? setterName)
    {
        throw new NotImplementedException();
    }

    public void RemoveSetterName()
    {
        throw new NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
