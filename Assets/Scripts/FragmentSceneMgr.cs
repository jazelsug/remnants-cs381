using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentSceneMgr : MonoBehaviour
{
    public GameObject noFragmentsText;

    [SerializeField]
    private GameObject[] fragmentPieces;

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
        //display "No Fragments" text if 0 fragments have been collected
        if(FragmentMgr.inst.collectedFragments.Count == 0)
        {
            noFragmentsText.SetActive(true);
        }
        else
        {
            noFragmentsText.SetActive(false);
        }

        //actions for different fragments with IDs 0-5
        if (FragmentMgr.inst.collectedFragments.Contains(0))
        {
            fragmentPieces[0].SetActive(true);
        }
        if (FragmentMgr.inst.collectedFragments.Contains(1))
        {
            fragmentPieces[1].SetActive(true);
        }
        if (FragmentMgr.inst.collectedFragments.Contains(2))
        {
            fragmentPieces[2].SetActive(true);
        }
        if (FragmentMgr.inst.collectedFragments.Contains(3))
        {
            fragmentPieces[3].SetActive(true);
        }
        if (FragmentMgr.inst.collectedFragments.Contains(4))
        {
            fragmentPieces[4].SetActive(true);
        }
        if (FragmentMgr.inst.collectedFragments.Contains(5))
        {
            fragmentPieces[5].SetActive(true);
        }
    }
}
