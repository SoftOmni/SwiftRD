using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Operators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

public class CompilerPlatformCondition : PlatformCondition
{
    public Identifier? CompilerIdentifier { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public Operator? Operator { get; internal set; }
    
    public SwiftVersion? SwiftVersion { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public CompilerPlatformCondition(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CompilerPlatformCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CompilerPlatformCondition(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public CompilerPlatformCondition(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
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