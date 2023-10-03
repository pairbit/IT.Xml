using IT.Hashing.Gost.Native;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace IT.Xml.C14N.Tests;

public class TransformTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        using var hashAlg = new Gost_R3411_2012_256_HashAlgorithm();

        //<Doc><Field>Значение\r\nполя документа</Field></Doc>
        var data = Utf8FromBase64("PERvYz48RmllbGQ+0JfQvdCw0YfQtdC90LjQtQ0K0L/QvtC70Y8g0LTQvtC60YPQvNC10L3RgtCwPC9GaWVsZD48L0RvYz4=");
        var hash = Convert.FromBase64String("oQwkI5hh95o6owmW29XJRFFI7Ne5k4HDe5wHcHpJmCM=");

        if (data.Contains("\r\n"))
        {
            data = data.Replace("\r\n", "\n");
        }

        var doc = new XmlDocument();
        doc.PreserveWhitespace = true;
        doc.LoadXml(data);

        //'\r' -> &#xD;
        var hash1 = IT_TransformC14(doc, hashAlg);
        var hash2 = Sys_TransformC14(doc, hashAlg);

        Assert.IsTrue(hash1.SequenceEqual(hash2));

        Assert.IsTrue(hash.SequenceEqual(hash1));
    }

    private static string Utf8FromBase64(string base64) => Encoding.UTF8.GetString(Convert.FromBase64String(base64));

    private static byte[] IT_TransformC14(XmlDocument xml, HashAlgorithm hashAlg)
    {
        var c14NTransform = new XmlDsigExcC14NTransform();

        c14NTransform.LoadInput(xml);

        //var ou = c14NTransform.GetOutput();

        return c14NTransform.GetDigestedOutput(hashAlg);
    }

    private static byte[] Sys_TransformC14(XmlDocument xml, HashAlgorithm hashAlg)
    {
        var c14NTransform = new System.Security.Cryptography.Xml.XmlDsigExcC14NTransform();

        c14NTransform.LoadInput(xml);

        return c14NTransform.GetDigestedOutput(hashAlg);
    }
}