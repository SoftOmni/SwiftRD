using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public interface ISwiftNode : ITreeNode
{
    public ISwiftNode? GetParent();

    public bool HasParent();

    public ISwiftNode? SetParent(ISwiftNode newParent);

    internal IEditableBuffer Buffer { get; }
    
    public int NumberOfChildren();
    
    public ISwiftNode this[int index] { get; internal set; }

    public ISwiftNode GetChildAt(int index);

    public ISwiftNode SetChildAt(int index, ISwiftNode newNode);
}