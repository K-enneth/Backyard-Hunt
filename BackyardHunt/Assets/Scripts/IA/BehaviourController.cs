using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourController : MonoBehaviour
{
    public List<SteeringBehaviours> behaviours = new List<SteeringBehaviours>();
    public Rigidbody rigidBody;
    public Vector3 velocity;
    public Vector3 totalForce = Vector3.zero;

    void FixedUpdate()
    {
        //inicializando en ceros
        totalForce = Vector3.zero;
        
        //Sacar el vector de la fuerza
        foreach ( SteeringBehaviours behaviour in behaviours)
        {
            behaviour.Position = transform.position;
            behaviour.Velocity = velocity;
            totalForce += behaviour.GetForce();
        }

        velocity += totalForce;
        transform.position += velocity * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -60, 60), Mathf.Clamp(transform.position.y, -3, 3), Mathf.Clamp(transform.position.z, -60,60));
        
    }
}
