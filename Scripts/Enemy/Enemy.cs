using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Player _player;

    public event UnityAction KillingPlayer;


    private void Update()
    {
        if (Vector2.Distance(transform.position, _player.transform.position) < 0.2)
            OnKillingPlayer();
    }


    private void OnKillingPlayer()
     {
        KillingPlayer?.Invoke();
     }
}
