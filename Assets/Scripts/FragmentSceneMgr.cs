using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentSceneMgr : MonoBehaviour
{
    public GameObject noFragmentsText;
    public GameObject corkboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //display "No Fragments" text if 0 fragments have been collected
        if(FragmentMgr.inst.collectedFragments.Count == 0)
        {
            noFragmentsText.SetActive(true);
            corkboard.SetActive(false); //MAY CHANGE LATER
        }
        else
        {
            noFragmentsText.SetActive(false);
            corkboard.SetActive(true); //MAY CHANGE LATER
        }

        //actions for different fragments with IDs 0-5
        if (FragmentMgr.inst.collectedFragments.Contains(0))
        {

        }
        if (FragmentMgr.inst.collectedFragments.Contains(1))
        {

        }
        if (FragmentMgr.inst.collectedFragments.Contains(2))
        {

        }
        if (FragmentMgr.inst.collectedFragments.Contains(3))
        {

        }
        if (FragmentMgr.inst.collectedFragments.Contains(4))
        {

        }
        if (FragmentMgr.inst.collectedFragments.Contains(5))
        {

        }
    }
}
