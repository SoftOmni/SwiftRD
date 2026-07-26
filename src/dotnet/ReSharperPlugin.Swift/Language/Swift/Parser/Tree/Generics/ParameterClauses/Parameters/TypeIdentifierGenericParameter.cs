using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public class TypeIdentifierGenericParameter : SwiftCompositeNode, ITypeIdentifierGenericParameter
{
    public IIdentifier GenericParameterName { get; }

    public Colon TypeIdentifierIntroducer { get; }

    public ITypeIdentifier TypeIdentifier { get; }

    internal TypeIdentifierGenericParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier genericParameterName, Colon typeIdentifierIntroducer, ITypeIdentifier typeIdentifier)
        : base(buffer, children)
    {
        GenericParameterName = genericParameterName;
        TypeIdentifierIntroducer = typeIdentifierIntroducer;
        TypeIdentifier = typeIdentifier;
    }

    IReadOnlyIdentifier IReadOnlyGenericParameter.GenericParameterName => GenericParameterName;

    IReadOnlyTypeIdentifier IReadOnlyTypeIdentifierGenericParameter.TypeIdentifier => TypeIdentifier;

    public void ChangeGenericParameterName(IIdentifier newGenericParameterName)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeTypeIdentifier(ITypeIdentifier newTypeIdentifier)
    {
        throw new System.NotImplementedException();
    }
}
