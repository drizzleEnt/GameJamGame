using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrimmerFace : MonoBehaviour
{
    [SerializeField] private float _timeOnScreen = 0.2f;

    private void OnEnable()
    {
        StartCoroutine(ShowingFace());
    }

    private IEnumerator ShowingFace()
    {
        yield return new WaitForSeconds(_timeOnScreen);
        gameObject.SetActive(false);
    }

    
}
