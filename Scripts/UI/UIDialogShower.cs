using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class UIDialogShower : MonoBehaviour
{
    [SerializeField] protected List<Sprite> IconWeWant;
    [SerializeField] protected Image IconConteiner;
    [SerializeField] protected TMP_Text Text;
    [SerializeField] protected Image PanelBackground;
    [SerializeField] protected List<string> TextYouWant = new List<string>();
    [SerializeField] protected float Deley;
    [SerializeField] protected float ShowTime;

    protected PlayerInput _playerInput;

    protected void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.Enable();
        _playerInput.Player.Space.performed += ctx => CloseDialog();
    }
    protected void DialogShow()
    {
        StopAllCoroutines();
        Text.text = "";
        StartCoroutine(TextShow(TextYouWant, Deley));

    }

    protected void CloseDialog()
    {
        StopAllCoroutines();
        Text.text = "";
        PanelBackground.gameObject.SetActive(false);
    }

    protected IEnumerator TextShow(List<string> text, float deley)
    {
        Text.text = "";
        PanelBackground.gameObject.SetActive(true);
        for (int j = 0; j < text.Count; j++)
        {
            IconConteiner.sprite = IconWeWant[j];
            Text.text = "";
            for (int i = 0; i < text[j].Length; i++)
            {
                Text.text += text[j][i].ToString();
                yield return new WaitForSeconds(deley);
            }
            yield return new WaitForSeconds(ShowTime);

        }
        yield return new WaitForSeconds(ShowTime);
        PanelBackground.gameObject.SetActive(false);
        Text.text = "";

    }
}
