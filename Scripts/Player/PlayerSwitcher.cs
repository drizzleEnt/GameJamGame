using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerSwitcher : MonoBehaviour
{
    public event UnityAction SwitchPlayer;

    private void OnDisable()
    {
        OnSwitchPlayer();
    }

    private void OnSwitchPlayer()
    {
        SwitchPlayer?.Invoke();
    }

}
