using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    public static SceneMgr inst;

    private void Awake()
    {
        inst = this;
    }

    public Slider slider;
    public Text progressText;

    private void Start()
    {
        if (slider != null)
        {
            slider.gameObject.SetActive(false);
        }
    }

    public void LoadOption(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        slider.gameObject.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }

    public void PlayGame()
    {
        //Scene 2 is StreetScene
        LoadOption(2);
    }

    public void GoToMenu()
    {
        //Scene 1 is Loader
        SceneManager.LoadScene(1);
    }

    public void GoToCredits()
    {
        //Scene 3 is Credits
        LoadOption(3);
    }

    public void GoToFragments()
    {
        //Scene 4 is Fragments
        LoadOption(4);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
