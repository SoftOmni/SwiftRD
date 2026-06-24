using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.DeclarationAttributes.AttachedAttribute;

public class AttachedAttribute : DeclarationAttribute<Macro>
{
    // TODO
    public AttachedAttribute(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AttachedAttribute(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AttachedAttribute(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public AttachedAttribute(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}