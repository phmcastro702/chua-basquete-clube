using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXController : MonoBehaviour
{
    private AudioSource audioSrc;
    private List<AudioClip> soundFXs = new List<AudioClip>();
    // Start is called before the first frame update
    void Start()
    {
        //Assets/Resources/Sounds/BallHitFloorSounds/hit0.mp3
        audioSrc = transform.GetComponentInChildren<AudioSource>();

        foreach (var audioClip in Resources.LoadAll<AudioClip>("Sounds/BallHitFloorSounds"))
        {
            soundFXs.Add(audioClip);
            Debug.Log(audioClip.name);
        }
    }

    public void OnBallHitFloor()
    {
        audioSrc.clip = soundFXs[0];
        audioSrc.Play();
    }

}
