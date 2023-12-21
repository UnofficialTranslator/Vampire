using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform player;
    
    [SerializeField] bool isDay = true;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyUp(KeyCode.E) && other.CompareTag("Player"))
        {
            ChangeTime();
        }
    }

    private void ChangeTime()
    {
        if (isDay)
        {
            Debug.Log("Hello");
            SetNight();
            isDay = false;
        }

        if (!isDay)
        {
            SetDay();
            isDay = true;
        }
    }

    private void SetDay()
    {
        player.localScale = new Vector3(0.75f, 0.75f, 1);
        Debug.Log("Day");
    }

    private void SetNight()
    {
        player.localScale = new Vector3(0.75f, 0.375f, 1);
        Debug.Log("Night");
    }
}
