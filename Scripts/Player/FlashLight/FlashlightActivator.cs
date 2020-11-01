using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightActivator : MonoBehaviour
{
    [SerializeField] private Light _flashlight;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.Enable();
        _playerInput.Player.Flashlight.performed += ctx => OnFlashlightActive();
        _flashlight.gameObject.SetActive(false);
    }


    private void OnDisable()
    {
        _playerInput.Disable();
    }
    private void OnFlashlightActive()
    {
        if (_flashlight.gameObject.activeSelf == false)
            _flashlight.gameObject.SetActive(true);
        else if (_flashlight.gameObject.activeSelf == true)
            _flashlight.gameObject.SetActive(false);
    }
}
