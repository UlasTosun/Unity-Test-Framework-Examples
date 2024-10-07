using UnityEngine;



public class PlayModeTestBridge : Singleton<PlayModeTestBridge> {

    [field: SerializeField]
    public GameObject Cube { get; private set; }

}
