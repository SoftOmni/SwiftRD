using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.CompositeStatements.Throws;

public class Throw : ControlTransferStatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "throw";

    public ThrowStatement? ThrowStatement { get; private set; }

    internal Throw(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Throw)
    { }

    internal Throw(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Throw)
    {
        if (parent is ThrowStatement throwStatement)
        {
            ThrowStatement = throwStatement;
        }
    }

    internal Throw(ThrowStatement throwStatement, IEditableBuffer buffer)
        : base(throwStatement, buffer, NodeTypes.NodeTypes.Throw)
    {
        ThrowStatement = throwStatement;
    }

    public static Throw Create()
    {
        return new Throw(new EditableBuffer(Keyword));
    }

    public static Throw Create(ThrowStatement throwStatement)
    {
        return new Throw(throwStatement, new EditableBuffer(Keyword));
    }

    internal static Throw CreateUnchecked(ISwiftNode parent)
    {
        return new Throw(parent, new EditableBuffer(Keyword));
    }

    public string KeywordValue => Keyword;

    public Expression? Expression => ThrowStatement?.Expression;

    public Function? Function => ThrowStatement?.Function;

    public bool HasFunction => ThrowStatement?.HasFunction ?? false;

    public bool HasNoFunctionAttached => ThrowStatement?.HasNoFunctionAttached ?? true;

    public bool HasExpression => ThrowStatement?.HasExpression ?? false;

    public bool HasNoExpression => ThrowStatement?.HasNoExpression ?? true; // TODO: Add type API
}