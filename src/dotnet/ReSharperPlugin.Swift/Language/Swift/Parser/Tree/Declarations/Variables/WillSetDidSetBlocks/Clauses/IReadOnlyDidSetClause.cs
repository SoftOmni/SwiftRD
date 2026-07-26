using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks.Clauses;

public interface IReadOnlyDidSetClause : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    DidSet DidSet { get; }
    
    LeftParenthesis? SetterNameStart { get; }
    
    IReadOnlyIdentifier? SetterName { get; }
    
    RightParenthesis? SetterNameEnd { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
