using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;

public class InitKeywordWrapper : SwiftCompositeNode, IInit
{
    public Init InitKeyword { get; }

    internal InitKeywordWrapper(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Init initKeyword)
        : base(buffer, children)
    {
        InitKeyword = initKeyword;
    }
}
