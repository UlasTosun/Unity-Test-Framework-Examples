using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;



[TestFixture]
public class EditModeTestExampleWithBridge {

    private Light _light;



    // [SetUp] is called before each test
    // A [UnitySetUp] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame.
    [UnitySetUp]
    public IEnumerator Setup() {
        EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity", OpenSceneMode.Single);
        yield return null; // skip a frame to wait for the scene to load

        _light = EditModeTestBridge.Instance.Light;
    }



    // A [UnityTest] behaves like a coroutine in Play Mode. In Edit Mode you can use `yield return null;` to skip a frame if needed.
    [UnityTest]
    public IEnumerator TestLightMode_ShouldBeRealtime() {
        yield return null; // skip a frame
        Assert.AreEqual(LightmapBakeType.Realtime, _light.lightmapBakeType, "Light mode should be Realtime.");
    }



    [Test]
    public void TestLightType_ShouldBeDirectional() {
        Assert.AreEqual(LightType.Directional, _light.type, "Light type should be Directional.");
    }



    // [TearDown] is called after each test
    [TearDown]
    public void TearDown() {
        _light = null;
    }



}
