using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public interface IDeclaration<TUsage> : IReadOnlyDeclaration<TUsage>, IDictionary<TUsage, TopLevelDeclaration>
{
    new IAccessLevelModifier DefaultAccessLevelModifier();

    void ChangeAccessLevelModifier(IAccessLevelModifier accessLevelModifier);
    
    
}
