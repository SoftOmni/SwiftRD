using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public class ProtocolCompositionTypeGenericParameter :
    SwiftCompositeNode, IProtocolCompositionTypeGenericParameter
{
    public IIdentifier GenericParameterName { get; }

    public Colon TypeIdentifierIntroducer { get; }

    public IProtocolCompositionType ProtocolCompositionType { get; }

    internal ProtocolCompositionTypeGenericParameter(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IIdentifier genericParameterName,
        Colon typeIdentifierIntroducer, IProtocolCompositionType protocolCompositionType)
        : base(buffer, children)
    {
        GenericParameterName = genericParameterName;
        TypeIdentifierIntroducer = typeIdentifierIntroducer;
        ProtocolCompositionType = protocolCompositionType;
    }

    IReadOnlyIdentifier IReadOnlyGenericParameter.GenericParameterName => GenericParameterName;

    IReadOnlyProtocolCompositionType IReadOnlyProtocolCompositionTypeGenericParameter.ProtocolCompositionType =>
        ProtocolCompositionType;

    public void ChangeGenericParameterName(IIdentifier newGenericParameterName)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeProtocolCompositionType(IProtocolCompositionType newProtocolCompositionType)
    {
        throw new System.NotImplementedException();
    }
}
