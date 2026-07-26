using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public class UnannotatedWillSetDidSetVariable : SwiftCompositeNode, ICodeBlockVariable
{
    public IAttributeGroup? Attributes { get; }
    
    public IDeclarationModifierGroup? DeclarationModifiers { get; }
    
    public Var Keyword { get; }
    
    public IIdentifier Name { get; }
    public IInitializer Initializer { get; }
    public IWillSetDidSetBlock WillSetDidSetBlock { get; }
}
