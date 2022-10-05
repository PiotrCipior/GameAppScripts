using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public Text myText;
    public static int value = 0;
    private static int marcin;
    private static int marcin2=0;
    int koszt = 20;
    public AudioClip klik;


    void start ()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = klik;
    }

    void FixedUpdate()
    {
        marcin = Buy.marcin;
        marcin2 = Buy.marcin2;
        if (marcin2 == 1 && koszt ==20)
        {
            value-=20;
            koszt = 0;
        }
        myText.text = "" + value;

        if (value>=35)
        {
            SceneManager.LoadScene("Credits");
        }
    }

    void OnMouseDown()
    {
        value += 1 + marcin;
        GetComponent<AudioSource> ().Play ();
        myText.text = "" + value;
    }

}
