using System;

namespace IT.Xml;

public interface IFullTagFinder : ITagFinder
{
    Range FirstInner(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, ReadOnlySpan<Char> ns, StringComparison comparison);

    Range Inner(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, ReadOnlySpan<Char> ns, StringComparison comparison);

    Range Inner(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, StringComparison comparison);

    ReadOnlySpan<Char> Inner(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, out Range range, StringComparison comparison);

    Range Outer(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, ReadOnlySpan<Char> ns, StringComparison comparison);

    Range Outer(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, StringComparison comparison);

    ReadOnlySpan<Char> Outer(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, out Range range, StringComparison comparison);

    Range LastInner(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, ReadOnlySpan<Char> ns, StringComparison comparison);

    Range LastInner(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, StringComparison comparison);

    ReadOnlySpan<Char> LastInner(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, out Range range, StringComparison comparison);

    Range LastOuter(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, ReadOnlySpan<Char> ns, StringComparison comparison);

    Range LastOuter(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, StringComparison comparison);

    ReadOnlySpan<Char> LastOuter(ReadOnlySpan<Char> chars, ReadOnlySpan<Char> name, out Range range, StringComparison comparison);
}