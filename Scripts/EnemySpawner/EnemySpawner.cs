using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CapsuleCollider2D))]
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private UnityEvent _spawnEnemy;

    private CapsuleCollider2D _collider;
    private int _countOfEnters =0;

    private void Start()
    {
        _collider = GetComponent<CapsuleCollider2D>();
    }

    private void Update()
    {
        if (_countOfEnters == 1)
            _collider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _spawnEnemy?.Invoke();
            _countOfEnters++;
        }
        
    }
}

