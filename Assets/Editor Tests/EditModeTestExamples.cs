using NUnit.Framework;



[TestFixture]
public class EditModeTestExamples {

    private StringAppend _stringAppend;





    // [SetUp] is called before each test
    [SetUp]
    public void SetUp() {
        _stringAppend = new StringAppend();
    }





    // TestCases are used to run the same test with different values. The test will run 2 times, with the following values sequentially.
    [Test]
    [TestCase("Hello", "World", "HelloWorld")] // First test case (a, b, expected)
    [TestCase("Hi", "There", "HiThere")] // Second test case (a, b, expected)
    public void Append_TwoNonEmptyStrings_ReturnsConcatenatedString(string a, string b, string expected) {
        string result = _stringAppend.Append(a, b);
        Assert.AreEqual(expected, result);
    }





    // TestCaseSource is used to run the same test with different values. The values are defined in an array.
    // This test will run 3 times, with the following value sets sequentially (a, b, expected):
    private static readonly object[] _emptyStringCases = {
        new object[] { "", "World", "World" },
        new object[] { "Hello", "", "Hello" },
        new object[] { "", "", "" }
    };

    [Test]
    [TestCaseSource(nameof(_emptyStringCases))]
    public void Append_EmptyStringAndNonEmptyString_ReturnsNonEmptyString(string a, string b, string expected) {
        string result = _stringAppend.Append(a, b);
        Assert.AreEqual(expected, result);
    }





    // Values are used to run the same test with different values.
    // This test works like a grid, testing all possible combinations of the values in the arrays.
    // The test will run 2 x 2 = 4 times, with the following possible combinations of the values:
    [Test]
    public void Append_TwoNonEmptyStrings_ReturnsNonEmptyString([Values("Hello", "World")] string a, [Values("Hello", "World")] string b) {
        string result = _stringAppend.Append(a, b);
        Assert.IsNotEmpty(result);
    }





    // ValueSource is used to run the same test with different values. The values are defined in an array.
    // This test works like a grid, testing all possible combinations of the values in the arrays.
    // The test will run 2 x 2 = 4 times, with the following possible combinations of the values:
    private static readonly string[] _emptyStringArray = { "", "" };
    private static readonly string[] _anotherEmptyStringArray = { "", "" };

    [Test]
    public void Append_TwoEmptyStrings_ReturnsEmptyString([ValueSource(nameof(_emptyStringArray))] string a, [ValueSource(nameof(_anotherEmptyStringArray))] string b) {
        string result = _stringAppend.Append(a, b);
        Assert.AreEqual("", result);
    }





    // [TearDown] is called after each test
    [TearDown]
    public void TearDown() {
        _stringAppend = null;
    }





}