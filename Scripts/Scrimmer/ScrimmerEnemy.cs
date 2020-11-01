using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrimmerEnemy : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        if (Vector2.Distance(transform.position, _target.position) < 0.2)
            gameObject.SetActive(false);
    }
}
