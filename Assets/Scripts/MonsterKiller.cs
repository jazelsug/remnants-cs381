using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterKiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        //make Devil isTrigger checked if using this function
        if (other.gameObject.CompareTag("Devil"))
        {
            //kill animation, put inst stuff in ReactToVehicleNew most likely
            MonsterKillCounter.inst.count += 1; //increment MonsterKillCounter count
        }
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Devil"))
            {
                //kill animation, put inst stuff in ReactToVehicleNew most likely
                MonsterKillCounter.inst.count += 1; //increment MonsterKillCounter count
                collision.gameObject.SetActive(false);  //deactivate - better place????
            }
        }
    }

}
