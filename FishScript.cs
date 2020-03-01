using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class FishScript : MonoBehaviour

    //first thing we need to do is spawn fishes

    
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Net")
        {
            Debug.Log("DEADFISH");
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Beach")
        {

            Destroy(this.gameObject);
        }
    }
}
