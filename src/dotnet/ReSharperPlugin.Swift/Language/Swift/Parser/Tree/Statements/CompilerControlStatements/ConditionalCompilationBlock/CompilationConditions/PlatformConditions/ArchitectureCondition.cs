using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

public class ArchitectureCondition : PlatformCondition
{
    public Identifier? ArchIdentifier { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public Identifier? Architecture { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    internal ArchitectureCondition(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    internal ArchitectureCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    internal ArchitectureCondition(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    internal ArchitectureCondition(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    public override bool Evaluatable()
    {
        throw new System.NotImplementedException();
    }

    public override bool Evaluate()
    {
        throw new System.NotImplementedException();
    }
}