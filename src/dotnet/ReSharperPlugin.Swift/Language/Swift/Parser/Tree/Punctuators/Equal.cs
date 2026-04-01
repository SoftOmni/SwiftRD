using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Equal : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = "=";
    
    internal Equal(IEditableBuffer buffer) 
        : base(buffer)
    { }

    internal Equal(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer) 
        : base(buffer, parent, parentIndex, parentTextIndex)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Equal;

    public string AsString => Value;

    public static Equal Create()
    {
        return new Equal(new EditableBuffer(Value));
    }
}