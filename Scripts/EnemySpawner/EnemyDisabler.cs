using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyDisabler : MonoBehaviour
{
    [SerializeField] private UnityEvent _disableEnemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
            _disableEnemy?.Invoke();
    }
}
