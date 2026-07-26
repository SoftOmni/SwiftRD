using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks.Clauses;

public interface IReadOnlyWillSetClause : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    WillSet WillSet { get; }
    
    LeftParenthesis? SetterNameStart { get; }
    
    IReadOnlyIdentifier? SetterName { get; }
    
    RightParenthesis? SetterNameEnd { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
