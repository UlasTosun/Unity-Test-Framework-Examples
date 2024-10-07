using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;



public class MyMonoBehaviourTest {



    // [SetUp] is called before each test
    // A [UnitySetUp] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnitySetUp]
    public IEnumerator Setup() {
        yield return new EnterPlayMode(); // make sure we are in play mode
        SceneManager.LoadScene("SampleScene"); // load the scene we want to test
        yield return new WaitForSeconds(0.5f); // make sure the scene is loaded
    }



    // A [UnityTest] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PositionTestWithEnumeratorPasses() {
        yield return new MonoBehaviourTest<MyMonoBehaviourToTest>(); // Run the test
    }



}