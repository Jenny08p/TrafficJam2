using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Interact : MonoBehaviour
{
    public GameObject ConfirmPurchase;
    public GameObject ConfirmPurchase1;
    public GameObject ConfirmPurchase2;
    public GameObject Equip1;
    public GameObject Equip2;
    public GameObject Equip3;
    public GameObject Variant1;
    public GameObject Variant2;
    public GameObject Variant3;

    public void StartGame(string level)
    {

     Application.LoadLevel("Game");
        
    }

    public void Level2(string level)
    {

        Application.LoadLevel("Level2");

    }

    public void Level3(string level)
    {

        Application.LoadLevel("Level3New");

    }

    public void Levels(string level)
    {

        Application.LoadLevel("Levels");

    }

    public void MainMenu(string level)
    {

        Application.LoadLevel("MainMenu");

    }

    public void Skins(string level)
    {

        Application.LoadLevel("SkinMenu");

    }
    public void Confirm1()
    {
        ConfirmPurchase.SetActive(true);
    }

    public void Confirm2()
    {
        ConfirmPurchase1.SetActive(true);
    }

    public void Confirm3()
    {
        ConfirmPurchase2.SetActive(true);
    }

    public void No()
    {
        ConfirmPurchase.SetActive(false);
    }

    public void Purchase()
    {
        ConfirmPurchase.SetActive(false);
        Variant1.SetActive(false);
        Equip1.SetActive(true);

    }

    public void Purchase2()
    {
        ConfirmPurchase1.SetActive(false);
        Variant2.SetActive(false);
        Equip2.SetActive(true);
    }

    public void Purchase3()
    {
        ConfirmPurchase2.SetActive(false);
        Variant3.SetActive(false);
        Equip3.SetActive(true);
    }


}
