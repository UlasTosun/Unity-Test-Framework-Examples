using UnityEngine;



// Execute in edit mode, so we can access the singleton instance in edit mode without running the game.
// Otherwise, the singleton instance would be null and test scripts throw a null reference exception.
[ExecuteInEditMode]
public class EditModeTestBridge : Singleton<EditModeTestBridge> {

    // Add objects that are needed for edit mode tests here.
    [field: SerializeField] public Camera MainCamera { get; private set; }

}
