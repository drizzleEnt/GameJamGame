using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperShower : UIDialogShower
{


    private void Start()
    {
        _playerInput.Player.ReadPaper.performed += ctx => PaperShow();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void PaperShow()
    {
        DialogShow();

    }
}
