using UnityEngine;
using System.Collections;

public class takeScreenShot : MonoBehaviour
{

    public KeyCode key = KeyCode.G;

    void Start()
    {
        DontDestroyOnLoad (gameObject);
    }

    string resolution;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G))
        {


            resolution = "" + Screen.width + "X" + Screen.height;
            Application.CaptureScreenshot("Highway_Rider_" + resolution + "_" + PlayerPrefs.GetInt("number", 0) + ".png", 1);
            PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number", 0) + 1);
            Debug.Log("takenShot with " + resolution);

        }

    }
}
