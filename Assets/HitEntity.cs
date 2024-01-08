using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _hitDamage;

    private void OnTriggerEnter(Collider other)
    {
        var h = other.gameObject.GetComponent<EntityHealth>();
        if (h!=null)
        {
            h.TakeDamage(5);
        }
    }
}
