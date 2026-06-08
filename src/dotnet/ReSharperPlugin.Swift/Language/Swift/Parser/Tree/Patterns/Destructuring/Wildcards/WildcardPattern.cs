using System;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Types.TypeAnnotations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Wildcards;

public class WildcardPattern : SwiftCompositeNode, IWildcardPattern
{
    public Underscore Underscore { get; }


    public ITypeAnnotation? TypeAnnotation { get; }

    internal WildcardPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Underscore underscore, ITypeAnnotation? typeAnnotation = null) :
        base(buffer, children)
    {
        Underscore = underscore;
        TypeAnnotation = typeAnnotation;
    }

    public bool HasTypeAnnotation => TypeAnnotation is not null;
    
    IReadOnlyTypeAnnotation? IReadOnlyWildcardPattern.TypeAnnotation => TypeAnnotation;

    public void SetTypeAnnotation(ITypeAnnotation typeAnnotation)
    {
        throw new NotImplementedException();
    }

    public bool HasFixedType()
    {
        throw new NotImplementedException();
    }

    public IType? Type()
    {
        if (CoreParent is null)
        {
            return null;
        }

        throw new NotImplementedException();
    }
}