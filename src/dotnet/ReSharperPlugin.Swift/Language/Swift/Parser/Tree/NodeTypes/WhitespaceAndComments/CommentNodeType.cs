namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.WhitespaceAndComments;

public abstract class CommentNodeType(string id, int index) : SwiftNodeType(id, index)
{
    public override bool IsWhitespace => false;

    public override bool IsComment => true;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;

    public override bool IsFiltered => true;
}