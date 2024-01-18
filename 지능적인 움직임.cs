using UnityEngine;
using System.Collections;
using System.Collections.Specialized;

public class Agent: MonoBehaviour
{
    public float maxSpeed;
    public float maxAccel;
    public float orientation;
    public float ratation;
    public Vector3 velocity;

    protected Steering steering;

    void Start()
    {
        velocity = vector3.zero;
        steering = new Steering();
    }

    public void SetSteering(Steering steering)
    {
        this.steering = steering;
    }
}