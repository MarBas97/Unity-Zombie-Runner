using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour
{

    public AudioClip initialHeliCall;
    public AudioClip initalCallReplay;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMakeInitialHeliCall()
    {
        audioSource.clip = initialHeliCall;
        audioSource.Play();

        Invoke("InitialReplay", initialHeliCall.length + 1f);
    }

    void InitialReplay()
    {
        audioSource.clip = initalCallReplay;
        audioSource.Play();

        BroadcastMessage("OnDispatcheHelicopter");
    }
}
