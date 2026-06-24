using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;

public class BoxedProtocolType : SwiftCompositeNode, IBoxedProtocolType
{
    public AnyLowercase Any { get; }
    
    public IType ConstraintType { get; }

    internal BoxedProtocolType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        AnyLowercase anyLowercase, IType constraintType)
        : base(buffer, children)
    {
        Any = anyLowercase;
        ConstraintType = constraintType;
    }

    IReadOnlyType IReadOnlyBoxedProtocolType.ConstraintType => ConstraintType;
    
    public IReadOnlyDeclaration? Declaration => null;

    public IReadOnlyType ActualType => this;
    
    public string TypeSignature => $"{AnyLowercase.Keyword} {ConstraintType.TypeSignature}";

    public IReadOnlyType? SuperType => null;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; } = [];

    public IReadOnlySet<IReadOnlyType> SubTypes => ModularVisibilityHashSet<IReadOnlyType>.Empty;

    public IReadOnlySet<string> SubTypeNames => ModularVisibilityHashSet<string>.Empty;

    public bool IsFromStandardLibrary => false;

    public int Size { get; }

    public void ChangeConstraintType(IType type)
    {
        throw new System.NotImplementedException();
    }
}
