using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogOfDimonShower : UIDialogShower
{
    [SerializeField] private UnityEvent _scrimmer;

    public void DialogsShow()
    {
        DialogShow();
    }



}
