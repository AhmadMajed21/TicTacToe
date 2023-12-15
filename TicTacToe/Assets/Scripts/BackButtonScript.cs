using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
    [SerializeField] GameScript gameScript;

    [SerializeField] GameObject register;
    [SerializeField] GameObject game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        //gameScript.xScore = 0;
        //gameScript.oScore = 0;
        //gameScript.ResetGame();
        //gameScript.turn = 1;
        //register.SetActive(true);
        //game.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
