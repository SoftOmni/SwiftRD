namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals.InterpolatableStringLiterals.SingleLine;
// TODO
//
// public class SingleLineStringLiteral : SwiftCompositeNode, IStringLiteral
// {
//     private StringBuilder UnderlyingValue => Content.Value;
//
//     public SingleLineStringLiteralStart Start { get; }
//
//     public SingleLineStringLiteralContent Content { get; }
//
//     public SingleLineStringLiteralEnd End { get; }
//
//     public IStringFormatting Formatting { get; }
//
//     internal SingleLineStringLiteral(IEditableBuffer buffer,
//         IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
//         SingleLineStringLiteralStart start, SingleLineStringLiteralContent content,
//         SingleLineStringLiteralEnd end)
//         : base(buffer, children)
//     {
//         Formatting = StringFormatting.Default();
//
//         Start = start;
//         Content = content;
//         End = end;
//     }
//
//     public String Type => String.Instance;
//
//     public string Value => UnderlyingValue.ToString();
//
//     public int Length => UnderlyingValue.Length;
//
//     public int LeadingHashtags => Start.LeadingHashtags;
//
//     public bool SupportsEscapes => false;
//
//     public bool SupportsInterpolations => false;
//
//     public string GetValueCopy()
//     {
//         return UnderlyingValue.ToString();
//     }
//
//     public void SetValue(string newValue)
//     {
//         SetValue(newValue, Formatting);
//     }
//
//     public void SetValue(string newValue, IStringFormatting formatting)
//     {
//         throw new NotImplementedException();
//     }
//
//     public char GetRawCharAt(int index)
//     {
//         return UnderlyingBuffer[index + 1 + LeadingHashtags];
//     }
//
//     public char GetCharAt(int index)
//     {
//         return UnderlyingValue[index];
//     }
//
//     public void SetRawCharAt(int index, char newCharacter)
//     {
//         if (newCharacter == Buffer[LeadingHashtags])
//         {
//             throw new StringLiteralDelimiterCharacterInsertionException(this, newCharacter, index);
//         }
//
//         UnderlyingBuffer.Replace(LeadingHashtags + index + 1, 1, newCharacter.ToString());
//     }
//
//     public void SetCharAt(int index, char newCharacter)
//     {
//         if (!char.IsControl(newCharacter)
//             && (newCharacter <= 127 ||
//                 Formatting.PreferredInsertionWay is not IStringFormatting.CharacterInsertion.UnicodeEscape))
//         {
//             UnderlyingBuffer.newCharacter;
//             UnderlyingValue[index] = newCharacter;
//             return;
//         }
//         
//         UnderlyingValue[index] = '\\';
//         if (Formatting.PreferredInsertionSimpleEscapeSupportedCharacters is IStringFormatting
//                 .SimpleEscapeSupportedCharacterInsertion.UnicodeEscape)
//         {
//             
//         }
//         
//         switch (newCharacter)
//         {
//             case '\0':
//                 UnderlyingValue.Insert(index + 1, '0');
//                 break;
//         }
//     }
//
//     public IEnumerator<char> GetRawEnumerator()
//     {
//         return new Enumerator(this);
//     }
//
//     public IEnumerator<char> GetValueEnumerator()
//     {
//         return new ValueEnumerator(this);
//     }
//
//     public IReadOnlyList<int> GetEscapeLocations()
//     {
//         throw new NotImplementedException();
//     }
//
//     public IReadOnlyList<int> GetInterpolationLocations()
//     {
//         throw new NotImplementedException();
//     }
//
//     public void ChangeFormatting(IStringFormatting formatting)
//     {
//         throw new NotImplementedException();
//     }
//
//     public struct Enumerator(SingleLineStringLiteral instance) : IEnumerator<char>
//     {
//         private SingleLineStringLiteral _instance = instance;
//
//         private int _position = -1;
//
//         public void Dispose()
//         {
//             // Noting to do
//         }
//
//         public bool MoveNext()
//         {
//             _position++;
//             return _instance.LeadingHashtags + _position + 1 <=
//                    _instance.UnderlyingBuffer.Length - 2 * _instance.Length - 2;
//         }
//
//         public void Reset()
//         {
//             _position = -1;
//         }
//
//         public char Current => _instance.UnderlyingBuffer[_instance.LeadingHashtags + _position + 1];
//
//         object IEnumerator.Current => Current;
//     }
//
//     public struct ValueEnumerator(SingleLineStringLiteral instance) : IEnumerator<char>
//     {
//         private SingleLineStringLiteral _instance = instance;
//
//         private int _position = -1;
//
//         public void Dispose()
//         {
//             // Noting to do
//         }
//
//         public bool MoveNext()
//         {
//             _position++;
//             return _position <= _instance.UnderlyingValue.Length;
//         }
//
//         public void Reset()
//         {
//             _position = -1;
//         }
//
//         public char Current => _instance.UnderlyingBuffer[_instance.UnderlyingValue[_position]];
//
//         object IEnumerator.Current => Current;
//     }
//
//     private void InsertCharacterAsUnicode(int index, char character)
//     {
//         StringBuilder unicodeScalarBuilder = new(11);
//         unicodeScalarBuilder.Append('u');
//         unicodeScalarBuilder.Append('{');
//             
//         int value = character;
//         while (value > 0)
//         {
//             int digit = value % 16;
//
//             if (digit < 10)
//             {
//                 unicodeScalarBuilder.Append((char)('0' + digit));
//             }
//             else if (Formatting.UnicodeEscapeHexadecimalCharacterCasing is IStringFormatting.Casing.Lowercase)
//             {
//                 digit -= 10;
//                 unicodeScalarBuilder.Append((char)('A' + digit));
//             }
//             else if (Formatting.UnicodeEscapeHexadecimalCharacterCasing is IStringFormatting.Casing.Uppercase)
//             {
//                 digit -= 10;
//                 unicodeScalarBuilder.Append((char)('a' + digit));
//             }
//             else
//             {
//                 // TODO: Log 
//             }
//
//             value /= 16;
//         }
//         
//         UnderlyingBuffer.Insert(LeadingHashtags + 1 + index, unicodeScalarBuilder.ToString());
//     }
// }