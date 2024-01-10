using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GoldUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityGold _playerGold;

    void Start()
    {
        _playerGold.OnGoldUpdate += UpdateGold;
        UpdateGold(_playerGold.GoldAmount);
    }

    // Update is called once per frame
    void UpdateGold(int amount)
    {
        _text.text = $"Gold:{amount}";
    }
}
