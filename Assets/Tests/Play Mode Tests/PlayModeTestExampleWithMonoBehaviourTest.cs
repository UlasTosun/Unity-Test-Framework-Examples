using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;



[TestFixture]
public class PlayModeTestExampleWithMonoBehaviourTest {



    // [SetUp] is called before each test
    // A [UnitySetUp] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnitySetUp]
    public IEnumerator Setup() {
        SceneManager.LoadScene("SampleScene"); // load the scene we want to test

        // Wait for two frames to allow the scene to load
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

    }



    // A [UnityTest] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MoveWithArrowsPressSpaceToTestPosition_ShouldNotBeAtOrigin() {
        yield return new MonoBehaviourTest<MonoBehaviourToTest>(); // Run the test
    }



}