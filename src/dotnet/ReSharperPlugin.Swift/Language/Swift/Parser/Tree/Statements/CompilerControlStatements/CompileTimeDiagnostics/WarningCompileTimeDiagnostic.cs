using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public class WarningCompileTimeDiagnostic : SwiftCompositeNode, IWarningCompileTimeDiagnostic
{
    public WarningDirective WarningDirective { get; }

    public LeftParenthesis ValueArgumentStart { get; }

    public IStringLiteral Value { get; }

    public RightParenthesis ValueArgumentEnd { get; }

    internal WarningCompileTimeDiagnostic(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        WarningDirective warningDirective, LeftParenthesis valueArgumentStart, IStringLiteral value,
        RightParenthesis valueArgumentEnd)
        : base(buffer, children)
    {
        WarningDirective = warningDirective;
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
