using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _diePannel;
    [SerializeField] private Enemy _enemyFirst;
    [SerializeField] private Enemy _enemySecond;
    [SerializeField] private PlayerSwitcher _switcher;
    [SerializeField] private GameObject _previousBody;
    [SerializeField] private Transform _positionEndGame;
    [SerializeField] private FinalTriggerZone _final;

    private PlayerMover _playerMover;
    private PlayerAnimationChanger _playerAnimationChanger;

    private SpriteRenderer _sprite;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _playerMover = GetComponent<PlayerMover>();
    }

    private void OnEnable()
    {
        _enemyFirst.KillingPlayer += ApplyDamage;
        _enemySecond.KillingPlayer += ApplyDamage;
        _switcher.SwitchPlayer += SwitchBody;
        _final.EndGame += OnGameEnd;
    }

    private void OnDisable()
    {
        _enemyFirst.KillingPlayer -= ApplyDamage;
        _enemySecond.KillingPlayer -= ApplyDamage;
        _switcher.SwitchPlayer -= SwitchBody;
        _final.EndGame -= OnGameEnd;
    }

    public void OnGameEnd()
    {
        transform.position = _positionEndGame.position;
        _playerMover.enabled = false;
        
    }

    public void ApplyDamage()
    {
        Die();
    }

    private void Die()
    {
        _diePannel.SetActive(true);
    }

    private void SwitchBody()
    {
        _previousBody.SetActive(false);
        _sprite.enabled = true;
    }
}
