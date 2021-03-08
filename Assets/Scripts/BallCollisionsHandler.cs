using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionsHandler : MonoBehaviour
{
    private SoundFXController mySoundFXController;

    void Start() 
    {
        mySoundFXController = transform.GetComponent<SoundFXController>();
    }


    private void OnCollisionEnter(Collision other) 
    {
        if(other.transform.CompareTag("floor"))
        {
            mySoundFXController.OnBallHitFloor();
        }
    }


}
