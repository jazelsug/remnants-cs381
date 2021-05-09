using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FragmentMgr : MonoBehaviour
{
    static public FragmentMgr inst;

    private List<int> collectedFragments;

    public GameObject vehicle;

    private void Awake()
    {
        inst = this;

        collectedFragments = new List<int>();

        // ensure this component will not be destroyed when switching levels
        //DontDestroyOnLoad(this);
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    /*
    private void OnLevelWasLoaded(int level)
    {
        var fragments = GameObject.FindObjectsOfType(typeof(Fragment));
        foreach(Fragment f in fragments)
        {
            //check if we've already collected the fragment
            if (collectedFragments.Contains(f.fragmentID))
            {
                //if we have collected it, then remove the object from the scene
                Destroy(f.gameObject);
            }
        }
    }
    */

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        var fragments = GameObject.FindObjectsOfType(typeof(Fragment));
        foreach (Fragment f in fragments)
        {
            //check if we've already collected the fragment
            if (collectedFragments.Contains(f.fragmentID))
            {
                //if we have collected it, then remove the object from the scene
                Destroy(f.gameObject);
            }
        }
    }

    public void CollectFragment(Fragment f)
    {
        /*
         if (_collectedCoins.Contains(coin.CoinId))
         {
           Debug.LogError("You've already collected " + coin.CoinId);
         }
         else
         {
           _collectedCoins.Add(coin.CoinId);
         }
         GameObject.Destroy(coin.gameObject);
     */

        if (collectedFragments.Contains(f.fragmentID))
        {
            Debug.LogError("Already collected fragment " + f.fragmentID);
        }
        else
        {
            collectedFragments.Add(f.fragmentID);
            Destroy(f.gameObject);
        }
    }
}
