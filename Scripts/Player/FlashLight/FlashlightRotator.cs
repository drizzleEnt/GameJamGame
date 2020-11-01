using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;

public class FlashlightRotator : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Vector3 _direction;
    private Vector2 _cursorPosition;
    private float _cameraDistance = -10;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.Enable();
    }
    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        _cursorPosition = _playerInput.Player.Cursor.ReadValue<Vector2>();
        Vector2 mousePosition = new Vector3( _cursorPosition.x, _cursorPosition.y, _cameraDistance);
        _direction = Camera.main.ScreenToWorldPoint(mousePosition);
        FlashlightRotation(_direction);
    }

    private void FlashlightRotation(Vector3 direction)
    {
        float dY = transform.position.y - direction.y;
        float dX = transform.position.x - direction.x;
        float rot = (Mathf.Atan2(dY , dX) * (180 / Mathf.PI));
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }
}
