#if NETSTANDARD2_0

using System;
using System.Runtime.CompilerServices;

namespace IT.Xml;

public static class xITagFinder
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 FirstOpen(this ITagFinder finder, ReadOnlySpan<Char> chars, String name, String ns, StringComparison comparison)
        => finder.FirstOpen(chars, name.AsSpan(), ns.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 LastOpen(this ITagFinder finder, ReadOnlySpan<Char> chars, String name, String ns, StringComparison comparison)
        => finder.LastOpen(chars, name.AsSpan(), ns.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 LastClose(this ITagFinder finder, ReadOnlySpan<Char> chars, String name, String ns, StringComparison comparison)
        => finder.LastClose(chars, name.AsSpan(), ns.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 LastClose(this ITagFinder finder, ReadOnlySpan<Char> chars, String name, StringComparison comparison)
        => finder.LastClose(chars, name.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<Char> LastClose(this ITagFinder finder, ReadOnlySpan<Char> chars, String name, out Int32 index, StringComparison comparison)
        => finder.LastClose(chars, name.AsSpan(), out index, comparison);
}

#endif