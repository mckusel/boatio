using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    public Transform fish1;
    public Transform fish2;
    public Transform fish3;
    public Transform fish4;
    public Transform barrel;
    public Transform iceberg;
    public Transform diamond;

    // Start is called before the first frame update
    void generate()
    {
        for (int i = 0; i < 15; i++)
        {
            Instantiate(fish1, new Vector3(Random.Range(-800.0f, 800.0f), 0f, Random.Range(-800.0f, 800.0f)), new Quaternion(0, Random.Range(0, 360.0f), 0, 0));
            Instantiate(fish2, new Vector3(Random.Range(-800.0f, 800.0f), 0f, Random.Range(-800.0f, 800.0f)), new Quaternion(0, Random.Range(0, 360.0f), 0, 0));
            Instantiate(fish3, new Vector3(Random.Range(-800.0f, 800.0f), 0f, Random.Range(-800.0f, 800.0f)), new Quaternion(0, Random.Range(0, 360.0f), 0, 0));
            Instantiate(fish4, new Vector3(Random.Range(-800.0f, 800.0f), 0f, Random.Range(-800.0f, 800.0f)), new Quaternion(0, Random.Range(0, 360.0f), 0, 0));
        }
    }
    void Start()
    {
        InvokeRepeating("generate", 0.0f, 10.0f);
        Instantiate(diamond, new Vector3(Random.Range(-800.0f, 800.0f), 0f, Random.Range(-800.0f, 800.0f)), new Quaternion(0, Random.Range(0, 360.0f), 0, 0));

        for (int j = 0; j < 20; j++)
        {
            Instantiate(barrel, new Vector3(Random.Range(-800.0f, 800.0f),0f, Random.Range(-800.0f, 800.0f)), new Quaternion(0, Random.Range(0.25f, 0.5f), 0, 0));
            Instantiate(iceberg, new Vector3(Random.Range(-800.0f, 800.0f), 0f, Random.Range(-800.0f, 800.0f)), Random.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
