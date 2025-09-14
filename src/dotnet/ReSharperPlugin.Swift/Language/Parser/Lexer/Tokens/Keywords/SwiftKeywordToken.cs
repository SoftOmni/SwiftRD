using System;
using JetBrains.Annotations;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

public class SwiftKeywordToken(string value, int index) : SwiftTokenNodeType(value, index)
{
    public override string TokenRepresentation { get; } = value;

    public override bool IsKeyword => true;

    public virtual bool ParameterUsable => false;
    
    public virtual bool DeclarationUsable => false;
    
    public virtual bool StatementUsable => false;
    
    public virtual bool PatternUsable => false;
    
    public virtual bool ContentSensitive => false;
    
    public virtual bool ReservedIdentifier => false;
    
    [CanBeNull] public virtual Version Availability => null;
    
    [CanBeNull] public virtual Version RemovalVersion => null;
}