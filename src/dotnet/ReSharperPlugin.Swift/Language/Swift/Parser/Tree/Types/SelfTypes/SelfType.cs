using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.SelfTypes;

public class SelfType : SwiftCompositeNode, ISelfType
{
    public Self Self { get; }
    
    private List<List<IReadOnlyType>> _subTypeChains { get; } = [];
    
    private ModularVisibilityHashSet<IReadOnlyType> _subTypes { get; } = [];
    
    private ModularVisibilityHashSet<string> _subTypeNames { get; } = [];

    internal SelfType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Self self)
        : base(buffer, children)
    {
        Self = self;
    }

    public IReadOnlyDeclaration? Declaration { get; internal set; } = null;
    
    public IReadOnlyType ActualType => this;

    public string TypeSignature => Self.KeywordValue;
    
    public IReadOnlyType? SuperType { get; internal set; } = null;
    
    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains => _subTypeChains;
    
    public IReadOnlySet<IReadOnlyType> SubTypes => _subTypes;
    
    public IReadOnlySet<string> SubTypeNames => _subTypeNames;
    
    public bool IsFromStandardLibrary { get; internal set; } = false;

    public int Size { get; }
}
