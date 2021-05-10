using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentSceneMgr : MonoBehaviour
{
    [SerializeField]
    private GameObject noFragmentDisplay;

    [SerializeField]
    private GameObject allFragmentDisplay;

    [SerializeField]
    private GameObject[] fragmentPieces;

    public AudioSource beforeAllFragmentsAudio;
    public AudioSource afterAllFragmentsAudio;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject g in fragmentPieces)
        {
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //play before all fragments audio
        if (!beforeAllFragmentsAudio.isPlaying && FragmentMgr.getFragmentList().Count != 6)
        {
            beforeAllFragmentsAudio.Play();
        }

        //display "No Fragments" text if 0 fragments have been collected
        if (FragmentMgr.getFragmentList().Count == 0)
        {
            noFragmentDisplay.SetActive(true);
        }
        else
        {
            noFragmentDisplay.SetActive(false);
        }

        //actions for different fragments with IDs 0-5
        if (FragmentMgr.getFragmentList().Contains(0))
        {
            fragmentPieces[0].SetActive(true);
        }
        if (FragmentMgr.getFragmentList().Contains(1))
        {
            fragmentPieces[1].SetActive(true);
        }
        if (FragmentMgr.getFragmentList().Contains(2))
        {
            fragmentPieces[2].SetActive(true);
        }
        if (FragmentMgr.getFragmentList().Contains(3))
        {
            fragmentPieces[3].SetActive(true);
        }
        if (FragmentMgr.getFragmentList().Contains(4))
        {
            fragmentPieces[4].SetActive(true);
        }
        if (FragmentMgr.getFragmentList().Contains(5))
        {
            fragmentPieces[5].SetActive(true);
        }

        //display "All Fragments" text if all 6 fragments have been collected
        if (FragmentMgr.getFragmentList().Count == 6)
        {
            allFragmentDisplay.SetActive(true);

            //play after all fragments audio
            if (!afterAllFragmentsAudio.isPlaying)
            {
                afterAllFragmentsAudio.Play();
            }
        }
        else
        {
            allFragmentDisplay.SetActive(false);
        }
    }
}
