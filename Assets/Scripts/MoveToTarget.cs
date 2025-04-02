using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    private Transform target;
    public float acceleration = 3.0f;
    public float maxSpeed = 5.0f;
    public float closeEnoughDistance = 0.5f;
    Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").transform;  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        velocity += direction.normalized * acceleration * Time.deltaTime;
        if (velocity.magnitude > maxSpeed)
        {
            velocity = direction.normalized * maxSpeed;
        }
        transform.position += velocity * Time.deltaTime;
    }
}
