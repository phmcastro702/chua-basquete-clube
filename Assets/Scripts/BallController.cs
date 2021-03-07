using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRb;
    public float throwForceFoward = 100;
    public float throwForceUp = 100;
    public float angle = 45;
    private Vector3 throwDirection;

    void Start()
    {
        ballRb = transform.GetComponent<Rigidbody>();

        throwDirection = new Vector3(0, Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle));

        Debug.DrawRay(transform.position, throwDirection, Color.blue, 20);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //var dir = new Vector3(0, Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle));
            Debug.Log("mouse pressed!");
            ballRb.AddForce(throwDirection * throwForceFoward);
            //ballRb.AddForce(throwDirection * throwForceUp);

        }
    }
}
