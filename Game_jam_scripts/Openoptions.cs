using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Openoptions : MonoBehaviour
{
    public GameObject options;
    public GameObject canvas;

    public void OnButtonPress()
    {
        options.SetActive(true);
        canvas.SetActive(false);

    }

}
