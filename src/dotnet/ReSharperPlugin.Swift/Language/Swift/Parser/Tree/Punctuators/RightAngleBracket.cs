using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class RightAngleBracket : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = ">";
    
    internal RightAngleBracket(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.RightAngleBracket;

    public string AsString => Value;

    public static RightAngleBracket Create()
    {
        return new RightAngleBracket(new EditableBuffer(Value));
    }
}