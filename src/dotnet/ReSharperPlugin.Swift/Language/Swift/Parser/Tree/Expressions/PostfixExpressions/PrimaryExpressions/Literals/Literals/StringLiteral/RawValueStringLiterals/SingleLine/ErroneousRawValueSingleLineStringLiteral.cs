using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals.Formatting;
using String = SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes.String;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;

public class ErroneousRawValueSingleLineStringLiteral : SwiftErrorCompositeNode, IStringLiteral
{
    private StringBuilder UnderlyingValue => Content.Value;
    
    public RawValueSingleLineStringLiteralStart Start { get; }
    
    public RawValueSingleLineStringLiteralContent Content { get; }
    
    public RawValueSingleLineStringLiteralEnd End { get; }
    
    public IStringFormatting Formatting { get; }

    internal ErroneousRawValueSingleLineStringLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        RawValueSingleLineStringLiteralStart start, RawValueSingleLineStringLiteralContent content, RawValueSingleLineStringLiteralEnd end)
        : base(buffer, children, "")
    { 
        Formatting = StringFormatting.Default();

        Start = start;
        Content = content;
        End = end;

        Message = GenerateMessage();
    }

    private string GenerateMessage()
    {
        return
            $"Error: A raw value single line string literal must have the same number of hash chars ('#') on both sides. " +
            $"On the left, there are {Start.LeadingHashtags} and on the right of it there are {End.LeadingHashtags}";
    }

    public String Type => String.Instance;
    
    public string Value => UnderlyingValue.ToString();

    public int Length => UnderlyingValue.Length;

    public int LeadingHashtags => Start.LeadingHashtags;

    public bool SupportsEscapes => false;

    public bool SupportsInterpolations => false;

    public string GetValueCopy()
    {
        return UnderlyingValue.ToString();
    }

    public void SetValue(string newValue)
    {
        SetValue(newValue, Formatting);
    }

    public void SetValue(string newValue, IStringFormatting formatting)
    {
        throw new NotImplementedException();
    }

    public char GetRawCharAt(int index)
    {
        return UnderlyingBuffer[index + 1 + LeadingHashtags];
    }

    public char GetCharAt(int index)
    {
        return UnderlyingValue[index];
    }

    public void SetRawCharAt(int index, char newCharacter)
    {
        throw new NotImplementedException();
        //TODO: Check if this is OK
        UnderlyingBuffer.Replace(index + 1 + LeadingHashtags, 1, newCharacter.ToString());
    }

    public void SetCharAt(int index, char newCharacter)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<char> GetRawEnumerator()
    {
        return new RawValueEnumerator(this);
    }

    public IEnumerator<char> GetValueEnumerator()
    {
        return new ValueEnumerator(this);
    }

    public IReadOnlyList<int> GetEscapeLocations()
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<int> GetInterpolationLocations()
    {
        throw new NotImplementedException();
    }

    public void ChangeFormatting(IStringFormatting formatting)
    {
        throw new NotImplementedException();
    }

    public struct RawValueEnumerator(ErroneousRawValueSingleLineStringLiteral instance) : IEnumerator<char>
    {
        private ErroneousRawValueSingleLineStringLiteral _instance = instance;

        private int _position = -1;

        public void Dispose()
        {
            // Noting to do
        }

        public bool MoveNext()
        {
            _position++;
            return _instance.LeadingHashtags + _position + 1 <= _instance.UnderlyingBuffer.Length - 2 * _instance.Length - 2;
        }

        public void Reset()
        {
            _position = -1;
        }

        public char Current => _instance.UnderlyingBuffer[_instance.LeadingHashtags + _position + 1];

        object IEnumerator.Current => Current;
    }
    
    public struct ValueEnumerator(ErroneousRawValueSingleLineStringLiteral instance) : IEnumerator<char>
    {
        private ErroneousRawValueSingleLineStringLiteral _instance = instance;

        private int _position = -1;

        public void Dispose()
        {
            // Noting to do
        }

        public bool MoveNext()
        {
            _position++;
            return _position <= _instance.UnderlyingValue.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        public char Current => _instance.UnderlyingBuffer[_instance.UnderlyingValue[_position]];

        object IEnumerator.Current => Current;
    }
}