using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public interface IReadOnlyMetaType : IReadOnlyType
{
    IReadOnlyType Type { get; }
    
    Period Period { get; }
}
