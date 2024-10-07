using UnityEngine;



/// <summary>
/// Base class for all singletons.
/// <para><typeparamref name="T"/> must be a <see cref="Component"/>.</para>
/// </summary>
public class Singleton<T> : MonoBehaviour where T : Component {

    /// <summary>
    /// Instance of the create singleton.
    /// </summary>
    public static T Instance { get; private set;}



    /// <summary>
    /// Override this method to create a custom instance of the singleton. Otherwise, <paramref name="Instance"/> will be null.
    /// </summary>
    protected virtual void Awake() {
        Instance = CreateOrGetInstance();
    }



    private T CreateOrGetInstance() {
        if (Instance == null)
            Instance = this as T;
        else if (Instance != this) {
            Debug.LogError("There is already an instance of '" + typeof(T).Name + "' in the scene");
            Destroy(this);
        }

        return Instance;
    }

}
