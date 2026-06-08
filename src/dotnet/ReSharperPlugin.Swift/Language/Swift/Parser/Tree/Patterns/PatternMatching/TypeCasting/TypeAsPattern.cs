using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public class TypeAsPattern : SwiftCompositeNode, ITypeAsPattern
{
    public IPattern Pattern { get; }
    
    public As As { get; }
    
    public IType Type { get; }

    public TypeAsPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPattern pattern, As @as, IType type)
        : base(buffer, children)
    {
        Pattern = pattern;
        As = @as;
        Type = type;
    }

    public void SetPattern(IPattern pattern)
    {
        throw new NotImplementedException();
    }

    public void SetType(IType type)
    {
        throw new NotImplementedException();
    }
}