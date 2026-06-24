using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class TypeParser
    {
        private const string BoxedProtocolTypeTypeKindIdentifier = "Self type"; 
        
        private static void ProcessBoxedProtocolType(IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack)
        {
            IEditableBuffer anyLowercaseTypeBuffer =
                new SubEditableBuffer(buffer, currentOffset, AnyLowercase.Keyword.Length);
            IEditableBuffer anyLowercaseBuffer =
                new SubEditableBuffer(anyLowercaseTypeBuffer, currentOffset, AnyLowercase.Keyword.Length);

            AnyLowercase anyLowercase = new(anyLowercaseBuffer);
            children.Add(anyLowercase);
            
            typesStack.Push(new TypeParserData(buffer, currentOffset, children,
                [(anyLowercase, 0)], 
                TypeParserData.TypeKind.GetOrCreate(BoxedProtocolTypeTypeKindIdentifier)));
        }
    }
}
