using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RegisterScript : MonoBehaviour
{
    [SerializeField] TMP_InputField player1Input; 
    [SerializeField] TMP_InputField player2Input; 
    [SerializeField] Button playButton;

    [SerializeField] GameScript gameScript;

    [SerializeField] GameObject game;
    [SerializeField] GameObject register;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        gameScript.xPlayerName = player1Input.text;
        gameScript.oPlayerName = player2Input.text;
        game.SetActive(true);
        register.SetActive(false);
    }
}
