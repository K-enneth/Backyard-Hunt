using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZone : AbstracZone
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aa");
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("enemy");
        }
        if (other.gameObject.CompareTag("Ally"))
        {
            Debug.Log("ally");
        }
    }

    public override Vector3 ActivateAbitity()
    {
        throw new System.NotImplementedException();
    }
}