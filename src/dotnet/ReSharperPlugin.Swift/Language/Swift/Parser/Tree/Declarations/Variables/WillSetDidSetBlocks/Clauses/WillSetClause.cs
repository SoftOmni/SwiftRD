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

public class WillSetClause : SwiftCompositeNode, IWillSetClause

{
    public IAttributeGroup? Attributes { get; }

    public WillSet WillSet { get; }

    public LeftParenthesis? SetterNameStart { get; }

    public IIdentifier? SetterName { get; }

    public RightParenthesis? SetterNameEnd { get; }

    public ICodeBlock CodeBlock { get; }

    internal WillSetClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, WillSet willSet,
        LeftParenthesis? setterNameStart, IIdentifier? setterName,
        RightParenthesis? setterNameEnd, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        WillSet = willSet;
        CodeBlock = codeBlock;
        SetterNameStart = setterNameStart;
        SetterName = setterName;
        SetterNameEnd = setterNameEnd;
    }

    IReadOnlyAttributeGroup? IReadOnlyWillSetClause.Attributes => Attributes;

    IReadOnlyCodeBlock IReadOnlyWillSetClause.CodeBlock => CodeBlock;

    IReadOnlyIdentifier? IReadOnlyWillSetClause.SetterName => SetterName;

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