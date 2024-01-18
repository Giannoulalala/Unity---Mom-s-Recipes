using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonClickmpif : MonoBehaviour
{
    // Start is called before the first frame update

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Intro");
                // OR Application.Quit();

                return;
            }

        }
    }

    public static int numofrecipe=0;
    public void BtnNewScene()
    {
        numofrecipe = 1;
        SceneManager.LoadScene("List");
    }

    public void BtnNewScenetwo()
    {
        numofrecipe = 2;
        SceneManager.LoadScene("List");
    }

    public void BtnNewScenethree()
    {
        numofrecipe = 3;
        SceneManager.LoadScene("List");
    }

    public void BtnNewScenefour()
    {
        numofrecipe = 4;
        SceneManager.LoadScene("List");
    }


    public void BtnNewScenefive()
    {
        numofrecipe = 5;
        SceneManager.LoadScene("List");
    }
    public void BtnNewScenesic()
    {
        numofrecipe = 6;
        SceneManager.LoadScene("List");
    }
    public void BtnNewSceneseven()
    {
        numofrecipe = 7;
        SceneManager.LoadScene("List");
    }
    public void BtnNewSceneeight()
    {
        numofrecipe = 8;
        SceneManager.LoadScene("List");
    }
    public void BtnNewScenenine()
    {
        numofrecipe = 9;
        SceneManager.LoadScene("List");
    }
    public void BtnNewSceneten()
    {
        numofrecipe = 10;
        SceneManager.LoadScene("List");
    }


    public void BtnBackScene()
    {
        SceneManager.LoadScene("Intro");
    }



}
