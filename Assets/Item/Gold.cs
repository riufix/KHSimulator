using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    [SerializeField] int _amount;
    [SerializeField]

    public event Action<int> OnGoldUpdate;
    public int Amount { get => _amount; private set => _amount = value; }

    void Start()
    {
        _amount = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        var h = other.GetComponent<Item>();
        if(h != null)
        {
            h.getGold();
        }
    }
}
