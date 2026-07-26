using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class QuestionMark : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = "?";
    
    internal QuestionMark(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.QuestionMark;

    public string AsString => Value;

    public static QuestionMark Create()
    {
        return new QuestionMark(new EditableBuffer(Value));
    }
}
