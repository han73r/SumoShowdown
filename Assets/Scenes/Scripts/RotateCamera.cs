using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private IInputManager _inputManager;

    private void Start() {
        _inputManager = InputManager.Instance;
    }

    void Update()
    {
        float horizontalInput = _inputManager.HorizontalInput();
        transform.Rotate(Vector3.up, horizontalInput * _rotationSpeed * Time.deltaTime);
    }
}
