using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;



[TestFixture]
public class MainCameraTest {

    private Camera _mainCamera;



    // [SetUp] is called before each test
    // A [UnitySetUp] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnitySetUp]
    public IEnumerator Setup() {
        EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity", OpenSceneMode.Single);
        yield return null; // skip a frame

        _mainCamera = EditModeTestBridge.Instance.MainCamera;
    }



    // A [UnityTest] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CameraNullTest() {
        yield return null; // skip a frame
        Assert.AreNotEqual(null, _mainCamera);
    }



}
