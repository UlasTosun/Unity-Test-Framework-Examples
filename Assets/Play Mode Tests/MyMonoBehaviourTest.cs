using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;



[TestFixture]
public class MyMonoBehaviourTest {



    // [SetUp] is called before each test
    // A [UnitySetUp] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnitySetUp]
    public IEnumerator Setup() {
        SceneManager.LoadScene("SampleScene"); // load the scene we want to test
        yield return new WaitForSeconds(0.5f); // make sure the scene is loaded
    }



    // A [UnityTest] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PositionTestWithEnumeratorPasses() {
        yield return new MonoBehaviourTest<MyMonoBehaviourToTest>(); // Run the test
    }



}