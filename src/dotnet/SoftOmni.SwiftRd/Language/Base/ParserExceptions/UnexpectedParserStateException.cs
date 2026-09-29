using System;

namespace SoftOmni.SwiftRd.Language.Base.ParserExceptions;

public class UnexpectedParserStateException(string message, string stateKind, int state)
    : Exception(message)
{
    public string StateKind { get; } = stateKind;
    
    public int State { get; } = state;
}