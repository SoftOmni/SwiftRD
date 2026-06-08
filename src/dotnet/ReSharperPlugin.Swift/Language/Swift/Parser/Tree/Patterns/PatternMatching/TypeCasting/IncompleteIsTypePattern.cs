using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public class IncompleteIsTypePattern : SwiftErrorCompositeNode, IIsTypePattern
{
    public Is Is { get; }

    public IType? Type => null;

    internal IncompleteIsTypePattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Is @is)
        : base(buffer, children, "missing type for is-type pattern matching pattern")
    {
        Is = @is;
    }

    public void SetType(IType type)
    {
        throw new NotImplementedException();
    }
}