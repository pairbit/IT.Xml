#if NETSTANDARD2_0

using System;
using System.Runtime.CompilerServices;

namespace IT.Xml;

public static class xIFullTagFinder
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range Inner(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, String ns, StringComparison comparison)
        => finder.Inner(chars, name.AsSpan(), ns.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range Inner(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, StringComparison comparison)
        => finder.Inner(chars, name.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<Char> Inner(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, out Range range, StringComparison comparison)
        => finder.Inner(chars, name.AsSpan(), out range, comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range Outer(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, String ns, StringComparison comparison)
        => finder.Outer(chars, name.AsSpan(), ns.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range Outer(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, StringComparison comparison)
        => finder.Outer(chars, name.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<Char> Outer(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, out Range range, StringComparison comparison)
        => finder.Outer(chars, name.AsSpan(), out range, comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range LastInner(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, String ns, StringComparison comparison)
        => finder.LastInner(chars, name.AsSpan(), ns.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range LastInner(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, StringComparison comparison)
        => finder.LastInner(chars, name.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<Char> LastInner(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, out Range range, StringComparison comparison)
        => finder.LastInner(chars, name.AsSpan(), out range, comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range LastOuter(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, String ns, StringComparison comparison)
        => finder.LastOuter(chars, name.AsSpan(), ns.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Range LastOuter(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, StringComparison comparison)
        => finder.LastOuter(chars, name.AsSpan(), comparison);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<Char> LastOuter(this IFullTagFinder finder, ReadOnlySpan<Char> chars, String name, out Range range, StringComparison comparison)
        => finder.LastOuter(chars, name.AsSpan(), out range, comparison);
}

#endif
