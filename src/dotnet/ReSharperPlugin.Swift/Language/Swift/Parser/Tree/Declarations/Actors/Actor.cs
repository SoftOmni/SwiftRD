using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actorures;

public class Actor : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Actor>
{
    public const string Keyword = "actor";
    
    public Actor()
        : base(new EditableBuffer())
    { }

    internal Actor(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Actor;

    public string KeywordValue => Keyword;

    public static Actor Create()
    {
        return new Actor(new EditableBuffer(Keyword));
    }
}
