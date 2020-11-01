using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _direction;
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.Enable();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        _direction = _playerInput.Player.Move.ReadValue<Vector2>();
        
        Move(_direction);
    }

    private void Move(Vector2 direction)
    {
        float scaledMoveSpeed = _speed * Time.deltaTime;
        Vector3 move = new Vector3(direction.x, direction.y, 0);
        transform.position += move * scaledMoveSpeed;
    }
}
