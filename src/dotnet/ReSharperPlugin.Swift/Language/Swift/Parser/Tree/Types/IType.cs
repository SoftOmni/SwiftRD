using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types.TupleTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types;

public interface IType : ISwiftNode, ITupleTypeElement
{
    public IType? DeclaredType { get; }
    
    public IType? ActualType { get; }
    
    public string TypeSignature { get; }

    public IType? SuperType { get; }

    public IReadOnlyList<IReadOnlyList<IType>> SubTypeChains { get; }
    
    public IReadOnlySet<IType> SubTypes { get; }
    
    public IReadOnlySet<string> SubTypeNames { get; }
    
    public bool IsFromStandardLibrary { get; }
    
    public bool IsEquivalentTo(IType otherType);
}