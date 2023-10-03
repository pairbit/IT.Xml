using System;

namespace IT.Xml;

public readonly record struct TagAttributeName
{
    public readonly Range _ns;
    public readonly Range _name;

    public Range NS => _ns;

    public Range Name => _name;

    public TagAttributeName(Range ns, Range name)
    {
        _ns = ns;
        _name = name;
    }
}