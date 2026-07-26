namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

public interface INewLine : IReadOnlyNewLine, IWhitespaceNode
{
    public void MakeLineFeed();

    public void MakeLf();

    public void MakeCarriageReturn();

    public void MakeCr();

    public void MakeLineFeedCarriageReturn();
}
