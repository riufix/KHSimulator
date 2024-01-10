using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] int _goldAmount;
    public int GoldAmount { get => _goldAmount; private set => _goldAmount = value; }
    public event Action<int> OnGoldUpdate;

    // Start is called before the first frame update
    void Start()
    {
        OnGoldUpdate?.Invoke(_goldAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoldUpdate(int amount)
    {
        if(amount != 0)
        {
            _goldAmount += amount;
            OnGoldUpdate?.Invoke(_goldAmount);
        }
    }
}
