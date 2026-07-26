using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class ExclamationMark : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = "!";
    
    internal ExclamationMark(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ExclamationMark;

    public string AsString => Value;

    public static ExclamationMark Create()
    {
        return new ExclamationMark(new EditableBuffer(Value));
    }
}
