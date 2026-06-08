using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class RightSquareBracket : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = "]";
    
    internal RightSquareBracket(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.RightSquareBracket;

    public string AsString => Value;

    public static RightSquareBracket Create()
    {
        return new RightSquareBracket(new EditableBuffer(Value));
    }
}