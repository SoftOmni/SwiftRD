using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public class NamelessTupleTypeElement : SwiftCompositeNode, INamelessTupleTypeElement
{
    public IType Type { get; }

    internal NamelessTupleTypeElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IType type)
        : base(buffer, children)
    {
        Type = type;
    }

    IReadOnlyType IReadOnlyNamelessTupleTypeElement.Type => Type;

    public void ChangeType(IType type)
    {
        throw new NotImplementedException();
    }
}
