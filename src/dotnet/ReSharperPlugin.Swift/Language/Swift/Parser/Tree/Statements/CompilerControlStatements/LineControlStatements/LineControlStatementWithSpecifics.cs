using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

public class LineControlStatementWithSpecifics : SwiftCompositeNode, ILineControlStatementWithSpecifics
{
    public ReservedSourceLocationKeyword SourceLocationKeyword { get; }
    
    public LeftParenthesis ArgumentsStart { get; }

    public IReadOnlyIdentifier FileArgumentLabel { get; }
    
    public Colon FileArgumentLabelValueSeparator { get; }

    public IStringLiteral FileArgumentValue { get; }
    
    public Comma FileLineArgumentsSeparator { get; }

    public IReadOnlyIdentifier LineArgumentLabel { get; }

    public Colon LineArgumentLabelValeSeparator { get; }

    public IIntegerLiteral LineArgumentValue { get; }

    public RightParenthesis ArgumentsEnd { get; }

    internal LineControlStatementWithSpecifics(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ReservedSourceLocationKeyword sourceLocationKeyword, LeftParenthesis argumentsStart,
        IReadOnlyIdentifier fileArgumentLabel, Colon fileArgumentLabelValueSeparator, IStringLiteral fileArgumentValue,
        Comma fileLineArgumentsSeparator, IReadOnlyIdentifier lineArgumentLabel, Colon lineArgumentLabelValeSeparator,
        IIntegerLiteral lineArgumentValue, RightParenthesis argumentsEnd)
        : base(buffer, children)
    {
        SourceLocationKeyword = sourceLocationKeyword;
        ArgumentsStart = argumentsStart;
        ArgumentsEnd = argumentsEnd;
        FileArgumentLabel = fileArgumentLabel;
        FileArgumentLabelValueSeparator = fileArgumentLabelValueSeparator;
        FileArgumentValue = fileArgumentValue;
        FileLineArgumentsSeparator = fileLineArgumentsSeparator;
        LineArgumentLabel = lineArgumentLabel;
        LineArgumentLabelValeSeparator = lineArgumentLabelValeSeparator;
        LineArgumentValue = lineArgumentValue;
    }

    IReadOnlyStringLiteral IReadOnlyLineControlStatementWithSpecifics.FileArgumentValue => FileArgumentValue;

    IReadOnlyIntegerLiteral IReadOnlyLineControlStatementWithSpecifics.LineArgumentValue => LineArgumentValue;

    public void ChangeFileArgumentValue(IStringLiteral stringLiteral)
    {
        throw new NotImplementedException();
    }

    public void ChangeLineArgumentValue(IIntegerLiteral integerLiteral)
    {
        throw new NotImplementedException();
    }
}
