using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public interface IReadOnlyPrecedenceGroupDeclaration : IReadOnlyDeclaration, IReadOnlyList<IReadOnlyPrecedenceGroupAttribute>
{
    PrecedenceGroupKeyword PrecedenceGroupKeyword { get; }
    
    IReadOnlyIdentifier Name { get; }
    
    LeftCurlyBrace AttributesStart { get; }
    
    IReadOnlyList<IReadOnlyPrecedenceGroupAttribute> PrecedenceGroupAttributes { get; }
    
    RightCurlyBrace AttributesEnd { get; }
    
    new IReadOnlyPrecedenceGroupAttribute this[int index] { get; }
}
