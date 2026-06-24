using System;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IFunctionCallArgument : IReadOnlyFunctionCallArgument
{
    new IIdentifier? Label { get; }
    
    void ChangeLabel(IIdentifier identifier);
    
    void RemoveLabel();

    void SetLabelTo(string label);
    
    void SetLabelTo(ReadOnlySpan<char> label);

    void SetLabelTo(IBuffer label);

    void SetLabelTo(IReadOnlyIdentifier identifier);

    void SetLabelTo(IIdentifier identifier);
}

