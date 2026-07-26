using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;

public class LabeledStatement : SwiftCompositeNode, ILabeledStatement
{
    public IIdentifier Label { get; }
    
    public Colon LabelSeparator { get; }

    internal LabeledStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IIdentifier label, Colon labelSeparator)
        : base(buffer, children)
    {
        Label = label;
        LabelSeparator = labelSeparator;
    }

    IReadOnlyIdentifier IReadOnlyLabeledStatement.Label => Label;

    public void ChangeLabel(IIdentifier newLabel)
    {
        throw new NotImplementedException();
    }
}
