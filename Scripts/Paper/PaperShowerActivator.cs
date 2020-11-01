using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PaperShowerActivator : MonoBehaviour
{
    [SerializeField] private GameObject _paperShower;
    [SerializeField] private GameObject _demonDialog;
    [SerializeField] private UnityEvent _scrimerActivator;

    private void OnTriggerStay2D(Collider2D collision)
    {
        _paperShower.SetActive(true);
      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _paperShower.SetActive(false);
        
        _scrimerActivator?.Invoke();
        gameObject.SetActive(false);
    }
}
