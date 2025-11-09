namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Markers;

public abstract class MarkerNodeType(string id, int index) : SwiftNodeType(id, index)
{
    public override bool IsWhitespace => false;
    
    public override bool IsComment => false;
    
    public override bool IsStringLiteral => false;
    
    public override bool IsConstantLiteral => false;
    
    public override bool IsIdentifier => false;
    
    public override bool IsKeyword => false;
    
    public override bool IsFiltered => false;
}