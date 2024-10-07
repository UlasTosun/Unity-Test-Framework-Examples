using NUnit.Framework;



[TestFixture]
public class StringAppendTest {
    private StringAppend stringAppend;



    // [SetUp] is called before each test
    [SetUp]
    public void SetUp() {
        stringAppend = new StringAppend();
    }



    [Test]
    [TestCase("Hello", "World", "HelloWorld")]
    [TestCase("Hi", "There", "HiThere")]
    public void Append_TwoNonEmptyStrings_ReturnsConcatenatedString(string a, string b, string expected) {
        string result = stringAppend.Append(a, b);
        Assert.AreEqual(expected, result);
    }



    private static object[] EmptyStringCases = {
        new object[] { "", "World", "World" },
        new object[] { "Hello", "", "Hello" },
        new object[] { "", "", "" }
    };



    [Test]
    [TestCaseSource(nameof(EmptyStringCases))]
    public void Append_EmptyStringAndNonEmptyString_ReturnsNonEmptyString(string a, string b, string expected) {
        string result = stringAppend.Append(a, b);
        Assert.AreEqual(expected, result);
    }



    // This test works like a grid, testing all possible combinations of the values in the arrays. The test will run 4 times, with the following values:
    [Test]
    public void Append_NonEmptyStringAndEmptyString_ReturnsNonEmptyString([Values("", "World")] string a, [Values("World", "")] string b) {
        string result = stringAppend.Append(a, b);
        Assert.IsTrue(true);
    }



    private static string[] emptyStringArray = { "", "" };



    [Test]
    public void Append_TwoEmptyStrings_ReturnsEmptyString([ValueSource(nameof(emptyStringArray))] string a) {
        string result = stringAppend.Append(a, "");
        Assert.AreEqual("", result);
    }



    // [TearDown] is called after each test
    [TearDown]
    public void TearDown() {
        stringAppend = null;
    }



}