using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CapsuleCollider2D))]
public class Dialog : MonoBehaviour
{
    [SerializeField] private UnityEvent _monologOfDimon;

    private int _nuberOfPlayerEneter = 0;
    private CapsuleCollider2D _collider;

    private void Start()
    {
        _collider = GetComponent<CapsuleCollider2D>();
    }

    private void Update()
    {
        if (_nuberOfPlayerEneter == 1)
            _collider.enabled = false;        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _nuberOfPlayerEneter++;
        _monologOfDimon?.Invoke();
    }
}
