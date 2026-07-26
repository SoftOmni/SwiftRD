using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.PlatformConditions.Imports;

public class CanImportPlatformCondition : SwiftCompositeNode, ICanImportPlatformCondition
{
    public IReadOnlyIdentifier PlatformConditionFunction { get; }

    public LeftParenthesis PlatformConditionFunctionArgumentsStart { get; }

    public IImportPath ImportPath { get; }

    public RightParenthesis PlatformConditionFunctionArgumentsEnd { get; }

    internal CanImportPlatformCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IReadOnlyIdentifier platformConditionFunction, LeftParenthesis platformConditionFunctionArgumentsStart,
        IImportPath importPath, RightParenthesis platformConditionFunctionArgumentsEnd)
        : base(buffer, children)
    {
        PlatformConditionFunction = platformConditionFunction;
        PlatformConditionFunctionArgumentsStart = platformConditionFunctionArgumentsStart;
        PlatformConditionFunctionArgumentsEnd = platformConditionFunctionArgumentsEnd;
        ImportPath = importPath;
    }

    IReadOnlyImportPath IReadOnlyCanImportPlatformCondition.ImportPath => ImportPath;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public void ChangeImportPath(IImportPath newImportPath)
    {
        throw new NotImplementedException();
    }
}
