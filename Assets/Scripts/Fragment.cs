using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment : MonoBehaviour
{
    public int fragmentID;
    public AudioSource fragmentPickupSound;
    //static public bool collected;

    // Start is called before the first frame update
    void Start()
    {
        //fragmentPickupSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Reset()
    {
        // Give each fragment a unique ID when added to a GameObject
        fragmentID = Random.Range(0, 10000);
    }

    /*
     void OnCollisionEnter(Collision col)
    {
        // change player name for the name of your players game object
        if (col.gameObject.name == "Car")
        {
            //increment kill counter
            MonsterKillCounter.inst.count++;

            //destroy devil
            Destroy(gameObject);
        }
    }
     */

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Car")
        {
            //play fragment collect sound
            fragmentPickupSound.Play();

            //add current fragment to list of collected fragments
            FragmentMgr.inst.CollectFragment(this);

            Destroy(gameObject);
        }
    }
}
