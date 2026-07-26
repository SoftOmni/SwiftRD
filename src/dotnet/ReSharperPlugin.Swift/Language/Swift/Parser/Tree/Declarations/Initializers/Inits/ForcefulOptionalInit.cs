using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;

public class ForcefulOptionalInit : SwiftCompositeNode, IForcefulOptionalInit
{
    public Init InitKeyword { get; }

    public ExclamationMark ExclamationMark { get; }

    internal ForcefulOptionalInit(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Init initKeyword, ExclamationMark exclamationMark)
        : base(buffer, children)
    {
        InitKeyword = initKeyword;
        ExclamationMark = exclamationMark;
    }
}
