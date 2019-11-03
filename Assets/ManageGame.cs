using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ManageGame : MonoBehaviour {

    // Elena wrote this to manage the opening screens of the game. This creates screen groups and
    // makes them visible as needed

    [SerializeField]  // this allows a var to appear in the inspector even though it is private
    private CanvasGroup titleScreen;

    [SerializeField]
    private CanvasGroup inputName;

    [SerializeField]
    private CanvasGroup instructPlayer;

    public Text tellPlayer;
    public InputField playerInput;
    public string playerName;



    void Awake() // when game starts, make title screen active and turn off the input name and instruct screens
    {
        inputName.alpha = 0f;
        inputName.interactable = false;
        inputName.blocksRaycasts = false;

        instructPlayer.alpha = 0f;
        instructPlayer.interactable = false;
        instructPlayer.blocksRaycasts = false;
    }

    public void LoadInputName() // when this function is called, turn off title screen and turn on input
    {

        inputName.alpha = 1f;
        inputName.interactable = true;
        inputName.blocksRaycasts = true;

        titleScreen.alpha = 0f;
        titleScreen.interactable = false;
        titleScreen.blocksRaycasts = false;

    }



    public void TeachPlayer() //when this function is called, turn off input screen and turn on instruct
    {

        inputName.alpha = 0f;
        inputName.interactable = false;
        inputName.blocksRaycasts = false;

        instructPlayer.alpha = 1f;
        instructPlayer.interactable = true;
        instructPlayer.blocksRaycasts = true;

    }

    public void TellPlayerHi()
    {
        playerName = playerInput.text;
        Debug.Log("name of player is: " + playerName);
        tellPlayer.text = "Hi " + playerName + " , let's ruffle some feathers";

    }

    public void PlayGame()
    {

        SceneManager.LoadScene("GameLevelOne");
        PlayerPrefs.SetString("ThisPlayer", playerName);
    }

}

