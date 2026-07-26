using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public class NamedTupleTypeElement : SwiftCompositeNode, INamedTupleTypeElement
{
    public IIdentifier ElementName { get; }

    public ITypeAnnotation TypeAnnotation { get; }

    public NamedTupleTypeElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier elementName, ITypeAnnotation typeAnnotation)
        : base(buffer, children)
    {
        ElementName = elementName;
        TypeAnnotation = typeAnnotation;
    }

    IReadOnlyIdentifier IReadOnlyNamedTupleTypeElement.ElementName => ElementName;

    IReadOnlyTypeAnnotation IReadOnlyNamedTupleTypeElement.TypeAnnotation => TypeAnnotation;

    public void ChangeElementName(IIdentifier identifier)
    {
        throw new NotImplementedException();
    }

    public void ChangeTypeAnnotation(ITypeAnnotation typeAnnotation)
    {
        throw new NotImplementedException();
    }
}