using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSetActive : MonoBehaviour
{
    public GameObject Light;
    public GameObject Disappear;
    public GameObject Animation;

    void OnTriggerEnter(Collider other)
    {
        Light.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        Light.SetActive(true);
    }
}