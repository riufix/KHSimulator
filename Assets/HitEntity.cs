using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _hitDamage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody == null) return;
        var h = other.attachedRigidbody.gameObject.GetComponent<EntityHealth>();
        if (h!=null)
        {
            h.TakeDamage(_hitDamage);
        }
    }
}
