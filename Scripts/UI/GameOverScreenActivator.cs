using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScreenActivator : MonoBehaviour
{
    [SerializeField] private UnityEvent _gameOver;

    private void OnDisable()
    {
        _gameOver?.Invoke();
    }
}
