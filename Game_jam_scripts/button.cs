using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject door;
    public GameObject button;

    void OnTriggerEnter2D(Collider2D button)
    {
            door.SetActive(false);
    }
}
