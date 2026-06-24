using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public class ProtocolMetaType : MetaType, IProtocolMetaData
{
    public ProtocolUppercase ProtocolKeyword { get; }

    public ProtocolMetaType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IType type,
        Period period, ProtocolUppercase protocolKeyword)
        : base(buffer, children, type, period)
    {
        ProtocolKeyword = protocolKeyword;
    }

    public override string TypeSignature => $"{Type.TypeSignature}.{ProtocolUppercase.Keyword}";
}
