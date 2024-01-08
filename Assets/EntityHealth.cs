using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;
    public int MaxHealth { get=> _maxHealth; private set => _maxHealth = value; }

    [SerializeField] UnityEvent _onDeath;

    public event Action<int> OnHealthUpdate;
    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int amount)
    {
        if(CurrentHealth != 0)
        {
            CurrentHealth -= amount;
            OnHealthUpdate.Invoke(CurrentHealth);
            if (CurrentHealth < 0)
            {
                _onDeath.Invoke();
            }
        }

    }


}
