using System;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Technology;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types;

public abstract class TypeInternalNode : SwiftInternalNode, IType
{
    private readonly List<List<IType>> _subTypeChains = [];

    private readonly ModularVisibilityHashSet<IType> _subTypes = [];
    
    private readonly Dictionary<string, IType> _subTypesByName = [];
    
    private readonly Dictionary<string, IType> _subTypesByFullName = [];
    
    private readonly Dictionary<IType, int> _subTypeChainIndex = []; 
    
    private readonly ModularVisibilityHashSet<string> _subTypeNames = [];

    protected TypeInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    {
        TypeSignature = buffer.GetText();
        DeclaredType = this;
        ActualType = this;
    }

    protected TypeInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    {
        TypeSignature = buffer.GetText();
        DeclaredType = this;
        ActualType = this;
    }

    protected TypeInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    {
        TypeSignature = buffer.GetText();
        DeclaredType = this;
        ActualType = this;
    }

    protected TypeInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    {
        TypeSignature = buffer.GetText();
        DeclaredType = this;
        ActualType = this;
    }

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