using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.AnyTypes;

public class AnyType : SwiftCompositeNode, IAnyType
{
    public AnyUppercase Any { get; }

    internal AnyType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, AnyUppercase any)
        : base(buffer, children)
    {
        Any = any;
    }

    public IReadOnlyDeclaration? Declaration => null;

    public IReadOnlyType ActualType => this;

    public string TypeSignature => Any.KeywordValue;

    public IReadOnlyType? SuperType => null;

    public IReadOnlySet<IReadOnlyType> SubTypes { get; } = new ModularVisibilityHashSet<IReadOnlyType>();

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; } = [];

    public IReadOnlySet<string> SubTypeNames { get; } = new ModularVisibilityHashSet<string>();

    public bool IsFromStandardLibrary => false;

    public int Size { get; }
}
