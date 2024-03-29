using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public static bool gameOver;
    public static int lives;

    public GameObject gameOverObject;

    public float sceneLoadDelay = 5;

    public Image shipSR3;
    public Image shipSR2;
    public Image shipSR1;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;   
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 2)
        {
            shipSR3.enabled = false;
        }
        if (lives == 1)
        {
            shipSR2.enabled = false;
        }
        if (lives == 0)
        {
            shipSR1.enabled = false;
            gameOver = true;
        }

        if (gameOver)
        {
            gameOverObject.SetActive(true);
            sceneLoadDelay -= Time.deltaTime;

            if (sceneLoadDelay <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
