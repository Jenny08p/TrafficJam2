using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerInfo : MonoBehaviour
{
    public const string Coins = "Coins";
    public static int coins = 0;

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }

    public static void UpdateCoins()
    {
        int prevCoins = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.SetInt("Coins", prevCoins + coins);
        PlayerPrefs.SetInt("Coins", coins);
        coins = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();
    }

}
