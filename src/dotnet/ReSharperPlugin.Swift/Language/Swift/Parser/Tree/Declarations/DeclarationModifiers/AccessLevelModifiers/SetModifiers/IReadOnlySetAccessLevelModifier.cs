using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.SetModifiers;

public interface IReadOnlySetAccessLevelModifier : IReadOnlyAccessLevelModifier
{
    IReadOnlyAccessLevelModifier AccessLevelModifier { get; }
    
    LeftParenthesis SetStart { get; }
    
    Set Set { get; }
    
    RightParenthesis SetEnd { get; }
}
