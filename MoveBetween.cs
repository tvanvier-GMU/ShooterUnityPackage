using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveBetween : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;
    public float speed = 1;
    Transform currentTarget;
    const float errorMargin = .001f;

    // Start is called before the first frame update
    void Start()
    {
        currentTarget = pointA;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, currentTarget.position) < errorMargin)
        {
            if (currentTarget == pointA)
                currentTarget = pointB;
            else
                currentTarget = pointA;
        }
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);
    }
}
