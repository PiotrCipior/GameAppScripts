using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    private Click myOtherClass;
    private static int value;
    public GameObject iks;
    public Text prawy;
    public GameObject OnButton;
    public GameObject button;
    public static int marcin = 0;
    public static int marcin2 = 0;

    void Update()
    {
        value = Click.value;
    }

    public void OnButtonPress()
    {
        if (value >= 20)
        {
            OnButton.SetActive(true);
            iks.SetActive(true);
            prawy.text = "Bought";
            Destroy(button);
            marcin = 1;
            marcin2 = 1;
        }
    }
}
