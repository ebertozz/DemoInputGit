using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageLevels : MonoBehaviour
{
    public Text greetPlayer;
    public string gamePlayer;

    // Start is called before the first frame update
    void Awake()
    {
        gamePlayer = PlayerPrefs.GetString("ThisPlayer");
        greetPlayer.text = "Hello " + gamePlayer;
    }
}
