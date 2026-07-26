using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;

public class FilePrivateAccessLevelModifier : SwiftCompositeNode, IFilePrivateAccessLevelModifier
{
    public FilePrivate FilePrivate { get; }

    internal FilePrivateAccessLevelModifier(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, FilePrivate filePrivate)
        : base(buffer, children)
    {
        FilePrivate = filePrivate;
    }
}
