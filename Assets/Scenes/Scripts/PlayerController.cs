using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private CharacterController _characterController;
    private Vector3 _moveDirection = Vector3.zero;

    [SerializeField] private GameObject _focalPoint;

    [SerializeField] private float _moveSpeed = 5.0f;
    private Rigidbody _playerRb;
    private IInputManager _inputManager;

    // TASK // Add Injector class
    //public void Inject(IInputManager inputManager) {
    //    _inputManager = inputManager;
    //}

    //https://learn.unity.com/tutorial/lesson-4-1-watch-where-you-re-going-1?uv=2020.3&projectId=5cf96846edbc2a2bcde6d0fc#

    private void Start() {
        _playerRb = GetComponent<Rigidbody>();
        _inputManager = InputManager.Instance;
    }

    private void Update() {
        float forwardInput = _inputManager.VerticalInput();
        _playerRb.AddForce(_focalPoint.transform.forward * _moveSpeed *  forwardInput);
    }


    //void Start() {
    //    _characterController = GetComponent<CharacterController>();
    //}
    //void Update() {
    //    _moveDirection = new Vector3(InputManager.Instance.HorizontalInput(), 0f, InputManager.Instance.VerticalInput());
    //    _moveDirection *= moveSpeed;
    //    _characterController.Move(_moveDirection * Time.deltaTime);
    //}
}
