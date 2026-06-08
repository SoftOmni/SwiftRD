using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class LeftParenthesis : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal LeftParenthesis(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.LeftParenthesis;

    public string AsString => Value;

    public static LeftParenthesis Create()
    {
        return new LeftParenthesis(new EditableBuffer(Value));
    }
}