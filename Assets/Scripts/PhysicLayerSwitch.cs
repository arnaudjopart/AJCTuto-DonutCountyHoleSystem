using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicLayerSwitch : MonoBehaviour
{
    public int m_defaultLayer;

    public int m_holeLayer;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.layer = m_holeLayer;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = m_defaultLayer;
    }
}
