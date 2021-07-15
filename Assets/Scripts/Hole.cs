using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public float m_growthFactor = 1.2f;
    public PhysicLayerSwitch m_physicLayerSwitch;
    
    public void Expand()
    {
        var currentScale = transform.localScale;
        transform.DOScale(currentScale * m_growthFactor, .3f).SetEase(Ease.OutBounce);
        m_physicLayerSwitch.m_sizeThreshold++;
    }
}
