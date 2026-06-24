using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static IAttributeGroup ParseAttributeGroupGivenStart(SwiftLexer lexer, ISwiftParsingSettings settings,
        IEditableBuffer buffer, int currentOffset, List<ISwiftNode<SwiftCompositeNode>> children)
    {
        
    }
}