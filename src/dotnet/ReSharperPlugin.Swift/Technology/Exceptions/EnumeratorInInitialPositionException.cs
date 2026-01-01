using System;
using System.Collections;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Technology.Exceptions;

/// <summary>
///     <para>
///         Represents an <see cref="Exception"/> to be thrown for when an enumerator is in its base position
///         after being initialized or right after a call to <see cref="IEnumerator.MoveNext"/> (or <see cref="IEnumerator{T}.MoveNext"/>
///         was made and <see cref="IEnumerator.Current"/> (or <see cref="IEnumerator{T}.Current"/>) was called.
///     </para>
///     <para>
///         This exception exists so that an <see cref="IEnumerator{T}"/> can have its generic type T be a non nullable type
///         and still provide a safeguard for when <see cref="IEnumerator.Current"/> (or <see cref="IEnumerator{T}.Current"/>)
///         is called and no value is available to provide if non is providable or makes sense to be providable in the initial state
///         of the <see cref="IEnumerator"/> (or <see cref="IEnumerator{T}"/>).
///     </para>
/// </summary>
public class EnumeratorInInitialPositionException() : Exception(GenerateBaseMessage())
{
    /// <summary>
    ///     This is a helper method which generates the message the <see cref="EnumeratorInInitialPositionException"/>
    ///     uses.
    /// </summary>
    /// <returns>
    ///     The generated message as a <see cref="string"/>.
    /// </returns>
    private static string GenerateBaseMessage()
    {
        return """
               Error: you tried calling an enumerator object while it was in its initial position.
               The initial position is not at the first callable element but one MoveNext call away from it.
               You must first call MoveNext before you can use Current.
               """;
    }
}