using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject Cube;

    private void OnTriggerEnter(Collider other)
    {
        Cube.SetActive(false);
    }
}
