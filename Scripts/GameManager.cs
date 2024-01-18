using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    bool gameOver = false;
    int score = 0;
    public Text scoreText;
    public GameObject gameoverPanel;
    public Text scoreTextPanel;
    int ouch = 3;
    public AudioSource kisses;
    public AudioSource sadfall;
    public Text lifesleft;
    public GameObject heart;
    public float sec;
    public GameObject pigkosagkalia;
    public GameObject red_heart_one;
    public GameObject red_heart_two;
    public GameObject red_heart_three;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("EnemySpawn").GetComponent<EnemySpawner>().StopSpawning();
        
        gameoverPanel.SetActive(true);
        if(score >= 10)
        {
            scoreTextPanel.text = "The Pigkos is safe. She loves you" ;
        }else if (ouch<= 0)
        {
            scoreTextPanel.text = "You kill the Pigko. Kakos Koukos";
        }
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            heart.SetActive(true);
            if (score == 1)
            {
                one.SetActive(true);
            }else if(score ==2)
            {
                two.SetActive(true);
            }else if (score == 3)
            {
                three.SetActive(true);
            }else if(score==4)
            {
                four.SetActive(true);
            }else if (score==5)
            {
                five.SetActive(true);
            }else if(score==6)
            {
                six.SetActive(true);
            }else if (score == 7)
            {
                seven.SetActive(true);
            }
            else if(score == 8)
            {
                eight.SetActive(true);
            }else if(score == 9)
            {
                nine.SetActive(true);
            }else if(score == 10)
            {
                ten.SetActive(true);
            }
            pigkosagkalia.SetActive(true);
            //gameObject.transform.parent = collision.gameObject.transform;
            //gameObject.transform.position = new Vector3(-0.24f, 1.235603f, 0f);
            StartCoroutine(lateheart());
            print(score);
            scoreText.text = "Score: "+ score;
            
            kisses.Play();
            if (score >= 10)
            {
                GameOver();
            }
        }
      
    }

   

   /*public void Ouch()
    {
        //13 24/521 -2.59,10
    }*/

    public void IncrementOuch()
    {
        if (!gameOver)
        {
            ouch--;
            //lifesleft.text = "LIVES LEFT " + ouch;
            sadfall.Play();
            if (ouch == 2)
            {
                red_heart_one.SetActive(false);
            }
            if (ouch == 1)
            {
                red_heart_two.SetActive(false);
            }
            if(ouch == 0)
            {
                red_heart_three.SetActive(false);
            }
            if (ouch <= 0)
            {
                GameOver();
            }
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }


    IEnumerator lateheart()
    {
        yield return new WaitForSeconds(sec);
        heart.SetActive(false);
        pigkosagkalia.SetActive(false);
    }
}
