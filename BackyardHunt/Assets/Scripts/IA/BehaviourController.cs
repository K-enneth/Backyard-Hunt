using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourController : MonoBehaviour
{
    public List<SteeringBehaviours> behaviours = new List<SteeringBehaviours>();
    
    private Vector3 _velocity;
    private Vector3 _totalForce = Vector3.zero;

    void FixedUpdate()
    {
        _totalForce = Vector3.zero;

        foreach ( SteeringBehaviours behaviour in behaviours)
        {
            behaviour.Position = transform.position;
            behaviour.Velocity = _velocity;
            _totalForce += behaviour.GetForce();
        }

        _velocity += _totalForce;
        transform.position += _velocity * Time.deltaTime;

    }
}
