using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Semicolon : SwiftLeafNode<SwiftCompositeNode>, ISwiftPunctuator
{
    public const string Value = ";";
    
    internal Semicolon(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Semicolon;

    public string AsString => Value;

    public static Semicolon Create()
    {
        return new Semicolon(new EditableBuffer(Value));
    }
}