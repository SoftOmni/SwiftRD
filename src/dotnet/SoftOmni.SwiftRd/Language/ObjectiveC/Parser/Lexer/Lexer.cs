using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

public partial class ObjectiveCLexer : IIncrementalLexer
{
    public ObjectiveCLexer(IBuffer buffer)
        : this(buffer, buffer.Length)
    { }
    
    public ObjectiveCLexer(IBuffer buffer, int eofPos)
    {
        
    }
    
    public void Start()
    {
        throw new System.NotImplementedException();
    }

    public void Advance()
    {
        throw new System.NotImplementedException();
    }

    public object CurrentPosition { get; set; }
    public TokenNodeType? TokenType { get; }
    public int TokenStart { get; }
    public int TokenEnd { get; }
    public IBuffer Buffer { get; }
    public uint LexerStateEx { get; }
    public void Start(int startOffset, int endOffset, uint state)
    {
        throw new System.NotImplementedException();
    }

    public int EOFPos { get; }
    public int LexemIndent { get; }
}
