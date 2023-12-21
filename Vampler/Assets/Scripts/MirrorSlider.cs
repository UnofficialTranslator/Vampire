using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MirrorSlider : MonoBehaviour
{
    [SerializeField] GameObject mirror;
    [SerializeField] CinemachineDollyCart slider;
    [SerializeField] LayerMask mask;
    [SerializeField] float distance;

    [System.Obsolete]
    void FixedUpdate()
    {
        mirror.transform.localRotation = Quaternion.Euler(1, 1, slider.m_Position * 20f);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            slider.m_Speed = -1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            slider.m_Speed = 1;
        }
        else slider.m_Speed = 0;
    }
}
