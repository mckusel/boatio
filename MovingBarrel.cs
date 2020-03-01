using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;
public class MovingBarrel : MonoBehaviour
{
    public GameObject barrel;
    public GameObject boat;
    bool motion;
    // Start is called before the first frame update
    void Start()
    {
         motion = (Random.value > 0.5f);
    }
        // Update is called once per frame
        void Update()
        {
        if(Vector3.Magnitude(boat.transform.position- barrel.transform.position) < 300.0f){
            if (motion == true)
            {
                transform.position = transform.position + new Vector3(0, 0, 10) * Time.deltaTime;
            }
            else
            {
                transform.position = transform.position + new Vector3(0, 0, -10) * Time.deltaTime;
            }
        }
        }
    }
