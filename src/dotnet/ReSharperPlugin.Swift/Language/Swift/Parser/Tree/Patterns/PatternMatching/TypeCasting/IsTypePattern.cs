using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public class IsTypePattern : SwiftCompositeNode, IIsTypePattern
{
    public Is Is { get; }
    
    public IType Type { get; }

    internal IsTypePattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Is @is, IType type)
        : base(buffer, children)
    {
        Is = @is;
        Type = type;
    }

    public void SetType(IType type)
    {
        throw new NotImplementedException();
    }
}