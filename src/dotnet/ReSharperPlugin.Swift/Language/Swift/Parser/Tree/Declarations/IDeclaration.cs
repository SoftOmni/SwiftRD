using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public interface IDeclaration<TUsage> : ISwiftInternalNode<SwiftCompositeNode>
{
    public IAccessLevelModifier DefaultAccessLevelModifier();
    
    public AnyCompiledIconClass Icon { get; }

    public IReadOnlyDictionary<TUsage, TopLevelDeclaration> Usages { get; }
}