using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public abstract class MetaType : SwiftCompositeNode, IMetaType
{
    public IType Type { get; internal set; }
    
    public Period Period { get; internal set; }

    private ModularVisibilityHashSet<IType> _subTypes = new();
    
    private ModularVisibilityHashSet<IReadOnlyType> _subTypesReadonly = new();

    private ModularVisibilityHashSet<string> _subTypeNames = new();

    protected MetaType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IType type,
        Period period)
        : base(buffer, children)
    {
        Type = type;
        Period = period;
    }

    IReadOnlyType IReadOnlyMetaType.Type => Type;

    public IReadOnlyDeclaration? Declaration { get; internal set; } = null;

    public IReadOnlyType ActualType => this;

    public abstract string TypeSignature { get; }

    public IReadOnlyType? SuperType { get; internal set; } = null;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; } = [];

    public IReadOnlySet<IReadOnlyType> SubTypes => _subTypesReadonly;

    public IReadOnlySet<string> SubTypeNames => _subTypeNames;

    public bool IsFromStandardLibrary => Type.IsFromStandardLibrary;

    public int Size { get; }

    public void ChangeType(IType type)
    {
        throw new System.NotImplementedException();
    }
}
