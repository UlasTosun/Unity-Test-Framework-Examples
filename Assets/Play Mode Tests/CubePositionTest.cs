using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;



[TestFixture]
public class CubePositionTest {

    private GameObject _gameObject;



    // [SetUp] is called before each test
    // A [UnitySetUp] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnitySetUp]
    public IEnumerator Setup() {
        yield return new EnterPlayMode(); // make sure we are in play mode
        SceneManager.LoadScene("SampleScene"); // load the scene we want to test
        yield return new WaitForSeconds(0.5f); // make sure the scene is loaded

        _gameObject = PlayModeTestBridge.Instance.Cube;
    }



    // A [UnityTest] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CubePositionTestWithEnumeratorPasses() {
        yield return WaitForInput();
        Assert.AreEqual(new Vector3(0, 0, 0), _gameObject.transform.position);
    }



    // [TearDown] is called after each test
    // A [UnityTearDown] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTearDown]
    public IEnumerator Teardown() {
        yield return new ExitPlayMode();
    }



    private IEnumerator WaitForInput() {
        while (!Input.GetKeyDown(KeyCode.Space)) {
            yield return null;
        }
    }



}
