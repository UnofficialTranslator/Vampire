using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCycle : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isDay", true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("isDay", !animator.GetBool("isDay"));
            // /\ and \/ are the same
            //bool currentIsDay = animator.GetBool("isDay");
            //bool newIsDay = !currentIsDay;
            //animator.SetBool("isDay", newIsDay);
        }
    }
}
