using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthSignal : MonoBehaviour
{
    public Hole m_hole;

    private void OnTriggerEnter(Collider other)
    {
        m_hole.Expand();
    }
}
