using UnityEngine;

public class GameManager : MonoBehaviour {
    private static readonly object lockObject = new object();
    private static GameManager _instance;
    public static GameManager Instance {
        get {
            lock (lockObject) {
                if (_instance == null) {
                    GameObject managerObject = new GameObject("GameManager");
                    _instance = managerObject.AddComponent<GameManager>();
                    DontDestroyOnLoad(managerObject);
                }
                return _instance;
            }
        }
    }
    private Injector _injector;
    private void Awake() {
        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    } 
    private void Start() {
        _injector = new Injector();
        InputManager inputManager = new InputManager();
        _injector.Init(inputManager);
    }
}
