using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{

    public float inc;
    public Transform MinX;
    public Transform MaxX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, MinX.position.x, MaxX.position.x), transform.position.y, transform.position.z);
        }

        else if(Input.GetKeyDown(KeyCode.A))
        {

            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, MinX.position.x, MaxX.position.x), transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
        }
        
    }
}

