using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class LeftPrecedenceGroupAssociativity : SwiftCompositeNode, ILeftPrecedenceGroupAssociativity
{
    public Associativity AssociativityKeyword { get; }

    public Colon AssociativityIntroducer { get; }

    public Left LeftKeyword { get; }

    internal LeftPrecedenceGroupAssociativity(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Associativity associativityKeyword,
        Colon associativityIntroducer, Left leftKeyword)
        : base(buffer, children)
    {
        AssociativityKeyword = associativityKeyword;
        AssociativityIntroducer = associativityIntroducer;
        LeftKeyword = leftKeyword;
    }
}
