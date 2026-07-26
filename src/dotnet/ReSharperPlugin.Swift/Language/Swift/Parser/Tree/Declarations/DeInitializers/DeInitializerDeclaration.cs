using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;

public class DeInitializerDeclaration : SwiftCompositeNode, IDeInitializerDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public DeInit DeInitKeyword { get; }

    public ICodeBlock CodeBlock { get; }

    internal DeInitializerDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, DeInit deInitKeyword, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeInitKeyword = deInitKeyword;
        CodeBlock = codeBlock;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }
    IReadOnlyAttributeGroup? IReadOnlyDeInitializerDeclaration.Attributes => Attributes;

    IReadOnlyCodeBlock IReadOnlyDeInitializerDeclaration.CodeBlock => CodeBlock;

    public void SetAttributesTo(IAttributeGroup? newAttributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
