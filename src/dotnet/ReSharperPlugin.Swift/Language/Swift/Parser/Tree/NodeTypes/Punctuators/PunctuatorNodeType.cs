namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Punctuators;

public abstract class PunctuatorNodeType(string id, int index) : SwiftNodeType(id, index)
{
    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;
}