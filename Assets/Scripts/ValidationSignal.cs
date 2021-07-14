using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationSignal : MonoBehaviour
{
    public Hole m_hole;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        m_hole.Expand();
    }
}