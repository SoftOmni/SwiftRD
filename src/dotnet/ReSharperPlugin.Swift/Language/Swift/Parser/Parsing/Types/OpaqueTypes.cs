using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class TypeParser
    {
        private const string OpaqueTypeTypeKindIdentifier = "some type"; 
        
        private static void ProcessOpaqueType(IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack)
        {
            IEditableBuffer opaqueTypeBuffer =
                new SubEditableBuffer(buffer, currentOffset, Some.Keyword.Length);
            IEditableBuffer someBuffer =
                new SubEditableBuffer(opaqueTypeBuffer, currentOffset, Some.Keyword.Length);

            Some some = new(someBuffer);
            children.Add(some);
            
            typesStack.Push(new TypeParserData(buffer, currentOffset, children,
                [(some, 0)], 
                TypeParserData.TypeKind.GetOrCreate(OpaqueTypeTypeKindIdentifier)));
        }
    }
}
