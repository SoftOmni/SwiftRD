using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public class TypeMetaType : MetaType, ITypeMetaData
{
    public Type TypeKeyword { get; }

    internal TypeMetaType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IType type,
        Period period, Type typeKeyword)
        : base(buffer, children, type, period)
    {
        TypeKeyword = typeKeyword;
    }

    public override string TypeSignature => $"{Type.TypeSignature}.{MetaTypes.Type.Keyword}";
}
