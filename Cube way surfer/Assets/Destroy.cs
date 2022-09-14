using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    int Score = 0;
    public Text ScoreText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Score++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score + " ";
        Nextscene();
    }
    void Nextscene()
    {
        if (Score >= 30)
            SceneManager.LoadScene(1);
    }
}
