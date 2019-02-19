﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour
{
    private bool foundClearArea = false;
    public float timeSinceLastTrigger = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime;
        if(timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea)
        {
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if(collider.tag  != "Player")
        {
            timeSinceLastTrigger = 0f;
        }
    }
}
