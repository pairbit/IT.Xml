using System;

namespace IT.Xml;

public readonly record struct TagAttribute
{
    public readonly Range _ns;
    public readonly Range _name;
    public readonly Range _value;

    public Range NS => _ns;

    public Range Name => _name;

    public Range Value => _value;

    public TagAttribute(Range ns, Range name, Range value)
    {
        _ns = ns;
        _name = name;
        _value = value;
    }
}