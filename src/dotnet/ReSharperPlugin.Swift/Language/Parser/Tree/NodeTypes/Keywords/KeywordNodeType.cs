namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords;

public abstract class KeywordNodeType(string id, int index) : SwiftNodeType(id, index)
{
    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => true;

    public override bool IsFiltered => false;
}