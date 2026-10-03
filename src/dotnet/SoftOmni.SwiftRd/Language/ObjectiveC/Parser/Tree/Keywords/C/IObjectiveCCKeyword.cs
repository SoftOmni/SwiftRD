namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public interface IObjectiveCCKeyword : IObjectiveCKeyword
{
    CStandard Standard { get; }
    
    enum CStandard
    {
        C89,
        C99,
        C11
    }
}
