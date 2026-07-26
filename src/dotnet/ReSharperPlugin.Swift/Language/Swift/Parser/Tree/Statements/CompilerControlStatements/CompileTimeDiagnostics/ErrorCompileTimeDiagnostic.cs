using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public class ErrorCompileTimeDiagnostic : SwiftCompositeNode, IErrorCompileTimeDiagnostic
{
    public ErrorDirective ErrorDirective { get; }

    public LeftParenthesis ValueArgumentStart { get; }

    public IStringLiteral Value { get; }

    public RightParenthesis ValueArgumentEnd { get; }

    internal ErrorCompileTimeDiagnostic(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ErrorDirective errorDirective, LeftParenthesis valueArgumentStart, IStringLiteral value,
        RightParenthesis valueArgumentEnd)
        : base(buffer, children)
    {
        ErrorDirective = errorDirective;
        ValueArgumentStart = valueArgumentStart;
        Value = value;
        ValueArgumentEnd = valueArgumentEnd;
    }

    IReadOnlyStringLiteral IReadOnlyCompileTimeDiagnostic.Value => Value;

    public void ChangeValue()
    {
        throw new NotImplementedException();
    }
}
