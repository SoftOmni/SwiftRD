using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public interface ICaptureList : IReadOnlyCaptureList, IList<ICaptureListItem>
{
    new IReadOnlyList<ICaptureListItem> Items { get; }
    
    new int Count { get; }

    new IEnumerator<ICaptureListItem> GetEnumerator();
    
    new ICaptureListItem this[int index] { get; }
}
