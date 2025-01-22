using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;



[TestFixture]
public class PlayModeTestExampleWithBridge {

    private GameObject _gameObject;



    // [SetUp] is called before each test
    // A [UnitySetUp] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnitySetUp]
    public IEnumerator Setup() {
        SceneManager.LoadScene("SampleScene"); // load the scene we want to test

        // Wait for two frames to allow the scene to load
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

        _gameObject = PlayModeTestBridge.Instance.Cube;
    }



    // A [UnityTest] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PressSpaceToTestPosition_ShouldBeAtOrigin() {
        yield return WaitForInput();
        Assert.AreEqual(Vector3.zero, _gameObject.transform.position, "Position should be at the origin.");
    }



    // [TearDown] is called after each test
    // A [UnityTearDown] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTearDown]
    public IEnumerator Teardown() {
        yield return null;
    }



    private IEnumerator WaitForInput() {
        while (!Input.GetKeyDown(KeyCode.Space)) {
            yield return null;
        }
    }



}
