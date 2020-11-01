using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CapsuleCollider2D))]
public class FinalTriggerZone : MonoBehaviour
{
    [SerializeField] private UnityEvent _monologOfDimon;

    public event UnityAction EndGame;

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
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _nuberOfPlayerEneter++;
            _monologOfDimon?.Invoke();
            EndGame?.Invoke();
        }
    }

}
