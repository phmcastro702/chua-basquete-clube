using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRb;
    public float throwForce;
    public float angle;
    private Vector3 throwDirection;

    private Vector3 originalPos;

    void Start()
    {
        ballRb = transform.GetComponent<Rigidbody>();

        angle = 45;

        throwForce = 500;

        throwDirection = new Vector3(0, Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle));

        Debug.DrawRay(transform.position, throwDirection, Color.blue, 20);

        originalPos = transform.position;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
            Invoke("ResetBallPosition", 4);
        }
    }

    private void ThrowBall()
    {
        Debug.Log("mouse pressed!");
        throwDirection = new Vector3(0, Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle));
        ballRb.AddForce(throwDirection * throwForce);
    }

    public void ListenToAngleValue(float value)
    {
        angle = Mathf.RoundToInt(value);
    }

    public void ListenToForceValue(float value)
    {
        throwForce = Mathf.RoundToInt(value);
    }

    private void ResetBallPosition()
    {
        ballRb.velocity = Vector3.zero;
        ballRb.angularVelocity = Vector3.zero;
        transform.position = originalPos;
    }
}
