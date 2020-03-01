using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TigerForge;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    float movementSpeed = -50f;
    public float movementMultiplier = 1f;
    public int kills;
    public int killtot;
    public AudioSource music;
    public Text score;
    private bool filter;
    public GameObject mycam;

    
    // Update is called once per frame

    void Start()
    {
        filter = false;
        //score = GameObject.FindGameObjectWithTag("Score");
        InvokeRepeating("DropNetCollider", 0f, 0.2f);
    }
    void Update()
    {
        score.text = killtot.ToString("00");
        movementMultiplier = Mathf.Clamp(1f + 0.2f * kills, 1f, 4f);
        transform.position += transform.forward * Time.deltaTime * movementSpeed * movementMultiplier;

        Quaternion originalRot = transform.rotation;


        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * movementMultiplier * 1.5f, 0));
        music.volume = Mathf.Clamp((kills - 3) / 8f, 0f, 1.0f);

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!filter)
            {
                mycam.GetComponent<CustomImageEffect>().enabled = true;
                filter = true;
            }
            else
            {
                mycam.GetComponent<CustomImageEffect>().enabled = false;
                filter = false;
            }
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Iceberg" ||
            collision.gameObject.tag == "Beach" ||
            collision.gameObject.tag == "shark")
        {
            Debug.Log("" + collision.gameObject.tag);
            GameManager.instance.Lose();
            /*SceneManager.LoadScene(SceneManager.GetActiveScene().name);*/
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Iceberg" ||
            other.gameObject.tag == "Beach" ||
            other.gameObject.tag == "shark")
        {
            Debug.Log("" + other.gameObject.tag);
            GameManager.instance.Lose();
            /*SceneManager.LoadScene(SceneManager.GetActiveScene().name);*/

        }
    }

    
}
