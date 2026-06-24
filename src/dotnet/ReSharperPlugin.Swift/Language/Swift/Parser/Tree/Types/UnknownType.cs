using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public class UnknownType : SwiftCompositeNode, IType
{
    public static UnknownType Instance { get; } = new(new EditableBuffer(string.Empty), []);

    internal UnknownType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children)
        : base(buffer, children)
    { }

    public IReadOnlyDeclaration? Declaration => null;
    
    public IReadOnlyType ActualType => this;
    
    public string TypeSignature => "ResharperUnknownType";
    
    public IReadOnlyType? SuperType => null;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; } = [];
    
    public IReadOnlySet<IReadOnlyType> SubTypes => ModularVisibilityHashSet<IReadOnlyType>.Empty;
    
    public IReadOnlySet<string> SubTypeNames => ModularVisibilityHashSet<string>.Empty;
    
    public bool IsFromStandardLibrary => false;

    public int Size => 8;
}
