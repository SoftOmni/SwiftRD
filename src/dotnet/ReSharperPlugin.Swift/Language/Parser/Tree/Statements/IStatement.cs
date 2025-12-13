namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

public interface IStatement : ISwiftNode
{
    public bool CanHaveMultipleOnOneLineSeparatedBySemicolons { get; }
}