using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] int _damage;
    public int Damage { get => _damage; set => _damage = value; }
    [SerializeField] float _attackDelay;
    [SerializeField] bool _waitForAttack;

    [SerializeField] InputActionReference _attack;

    [SerializeField] UnityEvent _OnAttack;

    // Start is called before the first frame update
    void Start()
    {
        _attack.action.started += Action_started;
    }

    private void Action_started(CallbackContext obj)
    {
        if (!_waitForAttack)
        {
            _waitForAttack = true;
            _OnAttack?.Invoke();
            StartCoroutine(Delay());
        }
    }

    public void AttackPoweUp(int  amount)
    {
        StartCoroutine(AttackPowerUpCoolDown());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(_attackDelay);
        _waitForAttack = false;
    }

    IEnumerator AttackPowerUpCoolDown()
    {
        _damage = 2;
        yield break;
    }
}
