using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public Transform m_hole;

    public Camera m_camera;

    public LayerMask m_layerMask;

    public float m_smoothTime = .1f;

    private Vector3 m_targetPosition;
    private Vector3 m_currentVelocity;

    // Update is called once per frame
    void Update()
    {
        var mousePosition = Input.mousePosition;
        var ray = m_camera.ScreenPointToRay(mousePosition);

        if (Physics.Raycast(ray, out var hit, 100, m_layerMask))
        {
            m_targetPosition = hit.point;
            
        }

        var smoothDampPosition = Vector3.SmoothDamp(m_hole.position, m_targetPosition, ref m_currentVelocity, m_smoothTime);
        m_hole.position = new Vector3(smoothDampPosition.x, 0, smoothDampPosition.z);
    }
}
