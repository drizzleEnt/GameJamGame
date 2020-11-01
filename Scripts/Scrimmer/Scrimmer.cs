using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrimmer : MonoBehaviour
{
    [SerializeField] private GameObject _enemyForScrimmer;
    [SerializeField] private GameObject _scrimmerFace;
 
    public void OnDisable()
    {
        _enemyForScrimmer.SetActive(true);
        _scrimmerFace.SetActive(true);
    }
}
