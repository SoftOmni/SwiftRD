using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.CompositeStatements.Throws;

public class Throw : ControlTransferStatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "throw";

    public ThrowStatement? ThrowStatement { get; private set; }

    internal Throw(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Throw)
    { }

    internal Throw(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Throw)
    {
        if (parent is ThrowStatement throwStatement)
        {
            ThrowStatement = throwStatement;
        }
    }

    internal Throw(ThrowStatement throwStatement, IEditableBuffer buffer)
        : base(throwStatement, buffer, SwiftNodeTypes.Throw)
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

    internal static Throw CreateUnchecked(SwiftInternalNode parent)
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