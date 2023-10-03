using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace IT.Xml.C14N.Internal;

// the class that provides node subset state and canonicalization function to XmlWhitespace
internal sealed class CanonicalXmlWhitespace : XmlWhitespace, ICanonicalizableNode
{
    private bool _isInNodeSet;

    public CanonicalXmlWhitespace(string strData, XmlDocument doc, bool defaultNodeSetInclusionState)
        : base(strData, doc)
    {
        _isInNodeSet = defaultNodeSetInclusionState;
    }

    public bool IsInNodeSet
    {
        get { return _isInNodeSet; }
        set { _isInNodeSet = value; }
    }

    public void Write(StringBuilder strBuilder, DocPosition docPos, AncestralNamespaceContextManager anc)
    {
        if (IsInNodeSet && docPos == DocPosition.InRootElement)
            strBuilder.Append(Utils.EscapeWhitespaceData(Value));
    }

    public void WriteHash(HashAlgorithm hash, DocPosition docPos, AncestralNamespaceContextManager anc)
    {
        if (IsInNodeSet && docPos == DocPosition.InRootElement)
        {
            UTF8Encoding utf8 = new UTF8Encoding(false);
            byte[] rgbData = utf8.GetBytes(Utils.EscapeWhitespaceData(Value));
            hash.TransformBlock(rgbData, 0, rgbData.Length, rgbData, 0);
        }
    }
}