using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class Ampersand : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "&";
    
    internal Ampersand(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public Ampersand()
        : base(new EditableBuffer(Value))
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.Ampersand;

    public string AsString => Value;

    public static Ampersand Create()
    {
        return new Ampersand(new EditableBuffer(Value));
    }
}
