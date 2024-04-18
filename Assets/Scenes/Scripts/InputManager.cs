using UnityEngine;

public interface IInputManager {
    float HorizontalInput();
    float VerticalInput();
}

public class InputManager : MonoBehaviour, IInputManager {
    private static InputManager _instance;
    public static InputManager Instance {
        get {
            if (_instance == null) {
                _instance = FindObjectOfType<InputManager>();
                if (_instance == null) {
                    GameObject inputManager = new GameObject("InputManager");
                    _instance = inputManager.AddComponent<InputManager>();
                }
            }
            return _instance;
        }
    }
    public float HorizontalInput() {
        return Input.GetAxis("Horizontal");
    }
    public float VerticalInput() {
        return Input.GetAxis("Vertical");
    }
}
