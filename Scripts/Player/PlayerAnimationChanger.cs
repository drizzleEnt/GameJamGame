using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]    
public class PlayerAnimationChanger : MonoBehaviour
{
    private Animator _animator;
    private Vector2 _direction;
    private PlayerInput _playerInput;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _playerInput = new PlayerInput();
        _playerInput.Enable();
    }
    private void OnDisable()
    {
        _playerInput.Disable();
    }
    
    private void Update()
    {
        _direction = _playerInput.Player.Move.ReadValue<Vector2>();
        AnimationChange(_direction); 
        
    }

    private void AnimationChange(Vector2 direction)
    {

        _animator.SetFloat("DirectionX", direction.x);
        _animator.SetFloat("DirectionY", direction.y);
        _animator.SetFloat("SpeedX", direction.x);
        _animator.SetFloat("SpeedY", direction.y);
        
    }
}
