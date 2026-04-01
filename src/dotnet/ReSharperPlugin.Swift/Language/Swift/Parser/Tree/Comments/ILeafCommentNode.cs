using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

namespace JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

public interface ILeafCommentNode : ICommentNode
{
    public char this[int index] { get; set; }
}