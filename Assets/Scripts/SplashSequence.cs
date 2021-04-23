using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashSequence : MonoBehaviour
{
    public static int SceneNumber;
    public GameObject loadingScreen;
    public Slider loadingBar;
    public Text progressText;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneNumber == 0)
        {
            StartCoroutine(ToGameMenu(1));
        }
    }

    /**
     * Loading MenuScene asynchronously
     * */
    IEnumerator ToGameMenu(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            loadingBar.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }
}
