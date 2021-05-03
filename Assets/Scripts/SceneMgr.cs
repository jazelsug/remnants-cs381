using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    /*
    public static int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        if (sceneIndex == 0)
        {
            StartCoroutine(ToGameMenu());
        }
    }
    */
    /**
     * Loading MenuScene asynchronously
     * */
    /*
    IEnumerator ToGameMenu()
    {
        yield return new WaitForSeconds(5);
        sceneIndex = 1;
        SceneManager.LoadScene(sceneIndex);
    }
    */
    public void PlayGame()
    {
        //Scene 2 is StreetScene
        //sceneIndex = 2;
        SceneManager.LoadScene(2);
    }

    public void GoToMenu()
    {
        //Scene 1 is Menu
        SceneManager.LoadScene(1);
    }

    public void GoToCredits()
    {
        //Scene 3 is Credits
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
