using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Item : MonoBehaviour
{
    [SerializeField] GameObject _pickedItem;
    [SerializeField] UnityEvent _OnPicked;

    public abstract bool ActiveEffect(GameObject player);


    private void OnTriggerEnter(Collider other)
    {

        bool wasAtcive = ActiveEffect(other.attachedRigidbody.gameObject);
        if (wasAtcive)
        Destroy(gameObject);
    }
}
