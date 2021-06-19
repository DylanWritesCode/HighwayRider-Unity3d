using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour {

    public Image loadingCircle;
    public Image TextLoader;
    public Text loadingInfo;
    public string SceneName;
    // Use this for initialization
    void Start()
    {
        loadingCircle.fillAmount = 0;
        if (TextLoader != null)
           TextLoader.fillAmount = 0;
        StartCoroutine("AsynchronousLoad");
    }

    IEnumerator AsynchronousLoad()
    {
        yield return null;

        AsyncOperation ao = SceneManager.LoadSceneAsync(SceneName);
        ao.allowSceneActivation = false;

        while (!ao.isDone)
        {
            // [0, 0.9] > [0, 1]
            float progress = Mathf.Clamp01(ao.progress / 0.9f);
            //Debug.Log("Loading progress: " + (progress * 100) + "%");
            loadingCircle.fillAmount = progress;
            if(TextLoader != null)
                TextLoader.fillAmount = progress;
            loadingInfo.text = Mathf.Floor(progress * 100.0f) + "%";
            // Loading completed
            if (ao.progress == 0.9f)
            {
                //clicked = false;
                ao.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
