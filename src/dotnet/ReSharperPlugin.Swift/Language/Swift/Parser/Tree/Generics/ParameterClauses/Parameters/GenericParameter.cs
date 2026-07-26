using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public class GenericParameter : SwiftCompositeNode, IGenericParameter
{
    public IIdentifier GenericParameterName { get; }

    internal GenericParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier genericParameterName)
        : base(buffer, children)
    {
        GenericParameterName = genericParameterName;
    }

    IReadOnlyIdentifier IReadOnlyGenericParameter.GenericParameterName => GenericParameterName;

    public void ChangeGenericParameterName(IIdentifier newGenericParameterName)
    {
        throw new System.NotImplementedException();
    }
}
