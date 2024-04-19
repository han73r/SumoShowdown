using UnityEngine;
public class InputManager : MonoBehaviour, IInputManager {
    private static readonly object lockObject = new object();
    private static InputManager _instance;
    public static InputManager Instance {
        get {
            lock (lockObject) {
                if (_instance == null) {
                    GameObject inputManager = new GameObject("InputManager");
                    _instance = inputManager.AddComponent<InputManager>();
                    DontDestroyOnLoad(inputManager);
                }
                return _instance;
            }
        }
    }
    public float HorizontalInput() {
        return Input.GetAxis("Horizontal");
    }
    public float VerticalInput() {
        return Input.GetAxis("Vertical");
    }
}
