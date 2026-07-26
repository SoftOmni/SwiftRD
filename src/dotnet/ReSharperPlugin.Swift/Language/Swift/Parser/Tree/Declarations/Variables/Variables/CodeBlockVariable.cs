using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public class CodeBlockVariable : SwiftCompositeNode, ICodeBlockVariable
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Var Keyword { get; }

    public IIdentifier Name { get; }

    public ITypeAnnotation TypeAnnotation { get; }

    public ICodeBlock CodeBlock { get; }

    internal CodeBlockVariable(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IDeclarationModifierGroup? declarationModifiers, Var keyword, IIdentifier name,
        ITypeAnnotation typeAnnotation, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        Keyword = keyword;
        Name = name;
        TypeAnnotation = typeAnnotation;
        CodeBlock = codeBlock;
    }

    public AnyCompiledIconClass Icon { get; }
    IReadOnlyAttributeGroup? IReadOnlyVariable.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyVariable.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyIdentifier IReadOnlyCodeBlockVariable.Name => Name;

    IReadOnlyTypeAnnotation IReadOnlyCodeBlockVariable.TypeAnnotation => TypeAnnotation;

    IReadOnlyCodeBlock IReadOnlyCodeBlockVariable.CodeBlock => CodeBlock;

    public void SetAttributesTo(IAttributeGroup? attributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new NotImplementedException();
    }

    public void SetDeclarationModifiers()
    {
        throw new NotImplementedException();
    }

    public void RemoveDeclarationModifiers()
    {
        throw new NotImplementedException();
    }

    public void ChangeNam(IIdentifier newName)
    {
        throw new NotImplementedException();
    }

    public void ChangeTypeAnnotation(ITypeAnnotation newTypeAnnotation)
    {
        throw new NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
