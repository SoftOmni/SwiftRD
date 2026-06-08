using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public abstract class TypeInternalNode : SwiftCompositeNode, IType
{
    private readonly List<List<IType>> _subTypeChains = [];

    private readonly ModularVisibilityHashSet<IType> _subTypes = [];
    
    private readonly Dictionary<string, IType> _subTypesByName = [];
    
    private readonly Dictionary<string, IType> _subTypesByFullName = [];
    
    private readonly Dictionary<IType, int> _subTypeChainIndex = []; 
    
    private readonly ModularVisibilityHashSet<string> _subTypeNames = [];

    protected TypeInternalNode(IEditableBuffer buffer) 
        : base(buffer)
    { }

    protected TypeInternalNode(SwiftCompositeNode parent, int index, IEditableBuffer editableBuffer, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null) 
        : base(parent, index, editableBuffer, children)
    { }

    protected TypeInternalNode(SwiftCompositeNode parent, int index, int textIndex, int lengthInParent, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null) 
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected TypeInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children) : base(buffer, children)
    { }

    public IType? DeclaredType { get; protected set; } = null;

    public IType? ActualType { get; protected set; } = null;
    
    public string TypeSignature { get; protected set; }
    
    public IType? SuperType { get; protected set; } = null;
    
    public IReadOnlyList<IReadOnlyList<IType>> SubTypeChains => _subTypeChains;
    
    public IReadOnlySet<IType> SubTypes => _subTypes;
    
    public IReadOnlySet<string> SubTypeNames => _subTypeNames;
    
    public bool IsFromStandardLibrary { get; internal set; } = false;
    
    public bool IsEquivalentTo(IType otherType)
    {
        throw new NotImplementedException();
    }
}