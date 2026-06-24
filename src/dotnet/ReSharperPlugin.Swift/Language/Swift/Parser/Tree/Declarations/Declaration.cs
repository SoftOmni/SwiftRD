using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public abstract class Declaration<TUsage> : SwiftCompositeNode, IDeclaration<TUsage>
{
    private Dictionary<TUsage, TopLevelDeclaration> _usages = [];
    
    protected Declaration(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected Declaration(SwiftCompositeNode parent, int index, IEditableBuffer editableBuffer, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected Declaration(SwiftCompositeNode parent, int index, int textIndex, int lengthInParent, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected Declaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children)
        : base(buffer, children)
    { }

    public abstract AnyCompiledIconClass Icon { get; }

    public IReadOnlyDictionary<TUsage, TopLevelDeclaration> Usages => _usages;
}