using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class openrecipe : MonoBehaviour
{

    public GameObject titleone;
    public GameObject image1;
    public GameObject titleylika1;
    public GameObject ylika1;
    public GameObject ektelesh1;

    public GameObject titletwo;
    public GameObject image2;
    public GameObject titleylika2;
    public GameObject ylika2;
    public GameObject ektelesh2;


    public GameObject titlethree;
    public GameObject imagethree;
    public GameObject tylikthree;
    public GameObject ylikathree;
    public GameObject ektelthree;

    public GameObject titlefour;
    public GameObject imagefour;
    public GameObject tylikfour;
    public GameObject ylikafour;
    public GameObject ektelfour;

    public GameObject titlefive;
    public GameObject imagefive;
    public GameObject tylikfive;
    public GameObject ylikafive;
    public GameObject ektelfive;

    public GameObject titlesix;
    public GameObject imagesix;
    public GameObject tyliksix;
    public GameObject ylikasix;
    public GameObject ektelsix;

    public GameObject titleseven;
    public GameObject imageseven;
    public GameObject tylikseven;
    public GameObject ylikaseven;
    public GameObject ektelseven;

    public GameObject titleeight;
    public GameObject imageeight;
    public GameObject tylikeight;
    public GameObject ylikaeight;
    public GameObject ekteleight;

    public GameObject titlenine;
    public GameObject imagenine;
    public GameObject tyliknine;
    public GameObject ylikanine;
    public GameObject ektelnine;

    public GameObject titleten;
    public GameObject imageten;
    public GameObject tylikten;
    public GameObject ylikaten;
    public GameObject ektelten;



    // Update is called once per frame
    void Update()
    {
        if (ButtonClickmpif.numofrecipe == 1){
            titleone.SetActive(true);
            image1.SetActive(true);
            titleylika1.SetActive(true);
            ylika1.SetActive(true);
            ektelesh1.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe == 2)
        {
            titletwo.SetActive(true);
            image2.SetActive(true);
            titleylika2.SetActive(true);
            ylika2.SetActive(true);
            ektelesh2.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe==3)
        {
            titlethree.SetActive(true);
            imagethree.SetActive(true);
            tylikthree.SetActive(true);
            ylikathree.SetActive(true);
            ektelthree.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe == 4)
        {
            titlefour.SetActive(true);
            imagefour.SetActive(true);
            tylikfour.SetActive(true);
            ylikafour.SetActive(true);
            ektelfour.SetActive(true);
        }else if (ButtonClickmpif.numofrecipe==5)
        {
            titlefive.SetActive(true);
            imagefive.SetActive(true);
            tylikfive.SetActive(true);
            ylikafive.SetActive(true);
            ektelfive.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe == 6)
        {
            titlesix.SetActive(true);
            imagesix.SetActive(true);
            tyliksix.SetActive(true);
            ylikasix.SetActive(true);
            ektelsix.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe == 7)
        {
            titleseven.SetActive(true);
            imageseven.SetActive(true);
            tylikseven.SetActive(true);
            ylikaseven.SetActive(true);
            ektelseven.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe == 8)
        {
            titleeight.SetActive(true);
            imageeight.SetActive(true);
            tylikeight.SetActive(true);
            ylikaeight.SetActive(true);
            ekteleight.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe == 9)
        {
            titlenine.SetActive(true);
            imagenine.SetActive(true);
            tyliknine.SetActive(true);
            ylikanine.SetActive(true);
            ektelnine.SetActive(true);
        }
        else if (ButtonClickmpif.numofrecipe == 10)
        {
            titleten.SetActive(true);
            imageten.SetActive(true);
            tylikten.SetActive(true);
            ylikaten.SetActive(true);
            ektelten.SetActive(true);
        }


    }
    public void BtnBack()
    {
        SceneManager.LoadScene("mpiftekia");
        ButtonClickmpif.numofrecipe = 0;
        titleone.SetActive(false);
        image1.SetActive(false);
        titleylika1.SetActive(false);
        ylika1.SetActive(false);
        ektelesh1.SetActive(false);
        titletwo.SetActive(false);
        image2.SetActive(false);
        titleylika2.SetActive(false);
        ylika2.SetActive(false);
        ektelesh2.SetActive(false);
        titlethree.SetActive(false);
        imagethree.SetActive(false);
        tylikthree.SetActive(false);
        ylikathree.SetActive(false);
        ektelthree.SetActive(false);
        titlefour.SetActive(false);
        imagefour.SetActive(false);
        tylikfour.SetActive(false);
        ylikafour.SetActive(false);
        ektelfour.SetActive(false);
        titlefive.SetActive(false);
        imagefive.SetActive(false);
        tylikfive.SetActive(false);
        ylikafive.SetActive(false);
        ektelfive.SetActive(false);
        titlesix.SetActive(false);
        imagesix.SetActive(false);
        tyliksix.SetActive(false);
        ylikasix.SetActive(false);
        ektelsix.SetActive(false);
        titleseven.SetActive(false);
        imageseven.SetActive(false);
        tylikseven.SetActive(false);
        ylikaseven.SetActive(false);
        ektelseven.SetActive(false);
        titleeight.SetActive(false);
        imageeight.SetActive(false);
        tylikeight.SetActive(false);
        ylikaeight.SetActive(false);
        ekteleight.SetActive(false);
        titlenine.SetActive(false);
        imagenine.SetActive(false);
        tyliknine.SetActive(false);
        ylikanine.SetActive(false);
        ektelnine.SetActive(false);
        titleten.SetActive(false);
        imageten.SetActive(false);
        tylikten.SetActive(false);
        ylikaten.SetActive(false);
        ektelten.SetActive(false);

    }
}
