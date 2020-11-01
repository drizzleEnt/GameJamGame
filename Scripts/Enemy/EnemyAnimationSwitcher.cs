using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyAnimationSwitcher : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        FindDirection(_target.position);
    }

    private void FindDirection(Vector3 direction)
    {
        float dY = transform.position.y - direction.y;
        float dX = transform.position.x - direction.x;
        float rot = (Mathf.Atan2(dY, dX) * (180 / Mathf.PI));
        _animator.SetFloat("Direction", rot);
    }
}
