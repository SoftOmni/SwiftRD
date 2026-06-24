using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

public class TargetEnvironmentCondition : PlatformCondition
{
    public Identifier? TargetEnvironment { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public Identifier? Environment { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    internal TargetEnvironmentCondition(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    internal TargetEnvironmentCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    internal TargetEnvironmentCondition(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    internal TargetEnvironmentCondition(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
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