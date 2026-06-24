using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;

public class OpaqueType : SwiftCompositeNode, IOpaqueType
{
    public Some Some { get; }

    public IType Type { get; private set; }
    
    private ModularVisibilityHashSet<IReadOnlyType> _subTypes { get; } = [];
    
    private ModularVisibilityHashSet<string> _subTypeNames { get; } = [];

    public OpaqueType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Some some, IType type)
        : base(buffer, children)
    {
        Some = some;
        Type = type;
        ActualType = this;
    }

    IReadOnlyType IReadOnlyOpaqueType.Type => Type;

    public IReadOnlyDeclaration? Declaration { get; internal set; } = null;

    public IReadOnlyType ActualType { get; internal set; }

    public string TypeSignature => $"{Some.KeywordValue} {Type.TypeSignature}";

    public IReadOnlyType? SuperType { get; internal set; } = null;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; } = [];

    public IReadOnlySet<IReadOnlyType> SubTypes => _subTypes;

    public IReadOnlySet<string> SubTypeNames => _subTypeNames;

    public bool IsFromStandardLibrary { get; internal set; } = false;

    public int Size { get; }

    public void ChangeType(IType type)
    {
        throw new NotImplementedException();
    }
}