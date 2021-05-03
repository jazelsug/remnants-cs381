using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSceneLoader : MonoBehaviour
{
    public static int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        if (sceneIndex == 0)
        {
            StartCoroutine(ToGameMenu());
        }
    }

    /**
     * Loading MenuScene asynchronously
     * */
    IEnumerator ToGameMenu()
    {
        yield return new WaitForSeconds(5);
        sceneIndex = 1;
        SceneManager.LoadScene(sceneIndex);
    }
}
