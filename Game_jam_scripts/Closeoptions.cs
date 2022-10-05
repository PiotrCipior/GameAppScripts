using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Closeoptions : MonoBehaviour
{
    public GameObject options;
    public GameObject canvas;

    public void OnButtonPress()
    {
        options.SetActive(false);
        canvas.SetActive(true);
    }
}
