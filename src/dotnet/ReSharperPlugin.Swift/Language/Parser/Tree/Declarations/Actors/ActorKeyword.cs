using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using JetBrains.Threading;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Actors;

public class ActorKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "actor";
    
    public Actor? Actor { get; internal set; }

    internal ActorKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Actor)
    { }

    internal ActorKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Actor)
    {
        if (parent is Actor actor)
        {
            Actor = actor;
        }
    }

    internal ActorKeyword(Actor parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Actor)
    {
        Actor = parent;
    }

    public string KeywordValue => Keyword;

    public static ActorKeyword Create()
    {
        return new ActorKeyword(new EditableBuffer(Keyword));
    }

    public static ActorKeyword Create(Actor actor)
    {
        return new ActorKeyword(actor, new EditableBuffer(Keyword));
    }

    public static ActorKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new ActorKeyword(parent, new EditableBuffer(Keyword));
    }
}