using UnityEngine;



public class PlayModeTestBridge : Singleton<PlayModeTestBridge> {

    // Add objects that are needed for play mode tests here.
    [field: SerializeField] public GameObject Cube { get; private set; }

}
