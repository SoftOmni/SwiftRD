using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ParenthesizedTypes;

public class ParenthesizedType : SwiftCompositeNode, IParenthesizedType
{
    public LeftParenthesis LeftParenthesis { get; }

    public IType Type { get; }
    
    public RightParenthesis RightParenthesis { get; }

    internal ParenthesizedType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftParenthesis leftParenthesis, IType type, RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        LeftParenthesis = leftParenthesis;
        Type = type;
        RightParenthesis = rightParenthesis;
    }

    IReadOnlyType IReadOnlyParenthesizedType.Type => Type;
    
    public IReadOnlyDeclaration? Declaration => Type.Declaration;

    public IReadOnlyType ActualType => Type.ActualType;

    public string TypeSignature => Type.TypeSignature;

    public IReadOnlyType? SuperType => Type.SuperType;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains => Type.SubTypeChains;

    public IReadOnlySet<IReadOnlyType> SubTypes => Type.SubTypes;

    public IReadOnlySet<string> SubTypeNames => Type.SubTypeNames;

    public bool IsFromStandardLibrary => Type.IsFromStandardLibrary;

    public int Size => Type.Size;

    public void ChangeType(IType type)
    {
        throw new NotImplementedException();
    }
}