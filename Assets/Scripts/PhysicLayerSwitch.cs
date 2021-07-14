using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicLayerSwitch : MonoBehaviour
{
    public int m_defaultLayer;
    public int m_holeLayer;
    public int m_sizeThreshold;

    private void OnTriggerEnter(Collider other)
    {
        var sizeRange = other.GetComponent<SizeRange>();
        if (sizeRange!=null)
        {
            var size = sizeRange.m_size;
            if (size <= m_sizeThreshold)
            {
                other.gameObject.layer = m_holeLayer;
            }
            return;
        }
        other.gameObject.layer = m_holeLayer;
    }

    private void OnTriggerExit(Collider other)
    {
       other.gameObject.layer = m_defaultLayer;
    }
}