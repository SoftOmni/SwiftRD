using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actors;

public class ActorKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeyword
{
    public const string Keyword = "actor";
    
    public Actor? Actor { get; internal set; }

    internal ActorKeyword(IEditableBuffer buffer) 
        : base(buffer)
    { }

    internal ActorKeyword(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        if (parent is Actor actor)
        {
            Actor = actor;
        }
    }

    internal ActorKeyword(Actor parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        Actor = parent;
    }

    public override NodeType NodeType => SwiftNodeTypes.Actor;

    public string KeywordValue => Keyword;

    public static ActorKeyword Create()
    {
        return new ActorKeyword(new EditableBuffer(Keyword));
    }
}