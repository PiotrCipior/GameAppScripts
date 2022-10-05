using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject drzwi;
    public GameObject guzik;

    void OnTriggerEnter2D(Collider2D guzik)
    {
            drzwi.SetActive(false);
    }
}
