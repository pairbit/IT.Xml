using System;

namespace IT.Xml;

public interface ITagFinder
{
    /// <summary>
    /// Данный метод ищет только начало открывающегося тега, последний '&gt;' не ищет!!!
    /// </summary>
    Int32 FirstOpen(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, ReadOnlySpan<char> ns, StringComparison comparison);

    //Range FirstOpenRange(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, ReadOnlySpan<char> ns, StringComparison comparison);

    Int32 FirstClose(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, ReadOnlySpan<char> ns, StringComparison comparison);

    /// <summary>
    /// Данный метод ищет только начало открывающегося тега, последний '&gt;' не ищет!!!
    /// </summary>
    Int32 LastOpen(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, ReadOnlySpan<char> ns, StringComparison comparison);

    //Range LastOpenRange(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, ReadOnlySpan<char> ns, StringComparison comparison);

    Int32 LastClose(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, ReadOnlySpan<char> ns, StringComparison comparison);

    Int32 LastClose(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, StringComparison comparison);

    ReadOnlySpan<char> LastClose(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, out Int32 index, StringComparison comparison);

    //ReadOnlySpan<char> Attr(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, ReadOnlySpan<char> ns, StringComparison comparison);

    //ReadOnlySpan<char> Attr(ReadOnlySpan<char> chars, ReadOnlySpan<char> name, out Range value, StringComparison comparison);

    //TagAttributeName AttrByVal(ReadOnlySpan<char> chars, ReadOnlySpan<char> value, StringComparison comparison);

    //TagAttribute[] Attrs(ReadOnlySpan<char> chars, StringComparison comparison);
}