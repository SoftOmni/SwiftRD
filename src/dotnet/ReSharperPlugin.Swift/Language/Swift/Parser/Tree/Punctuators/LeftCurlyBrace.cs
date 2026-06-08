using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class LeftCurlyBrace : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = "{";
    
    internal LeftCurlyBrace(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.LeftCurlyBrace;

    public string AsString => Value;

    public static LeftCurlyBrace Create()
    {
        return new LeftCurlyBrace(new EditableBuffer(Value));
    }
}