using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    [SerializeField] List<TMP_Text> cells;
    [SerializeField] List<Button> cellButtons;

    [SerializeField] TMP_Text xPlayerNameText;
    [SerializeField] TMP_Text oPlayerNameText;

    float turn = 1;

    public string xPlayerName;
    public string oPlayerName;

    public int xScore = 0;
    public int oScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        xPlayerNameText.text = xPlayerName + " " + xScore.ToString();
        oPlayerNameText.text = oPlayerName + " " + oScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(cells[0].text != "" && cells[1].text != "" && cells[2].text != ""
            && cells[3].text != "" && cells[4].text != "" && cells[5].text != ""
            && cells[6].text != "" && cells[7].text != "" && cells[8].text != "")
        {
            CheckTie();
        }
    }

    public void CellButton(int cell)
    {
        cellButtons[cell].gameObject.SetActive(false);

        if(turn == 1)
        {
            cells[cell].text = "X";
            cells[cell].color = new Color(255, 0, 0);
            turn--;
        }
        else if(turn == 0)
        {
            cells[cell].text = "O";
            cells[cell].color = new Color(134, 0, 255);
            turn++;
        }
    }

    public void CheckWin()
    {
        //Rows
        if (cells[0].text == cells[1].text && cells[0].text == cells[2].text && cells[0].text != "")
        {
            UpdateScore(0);
            ResetGame();
        }

        if (cells[3].text == cells[4].text && cells[3].text == cells[5].text && cells[3].text != "")
        {
            UpdateScore(3);
            ResetGame();
        }

        if (cells[6].text == cells[7].text && cells[6].text == cells[8].text && cells[6].text != "")
        {
            UpdateScore(6);
            ResetGame();
        }

        //Collumns
        if (cells[0].text == cells[3].text && cells[0].text == cells[6].text && cells[0].text != "")
        {
            UpdateScore(0);
            ResetGame();
        }

        if (cells[1].text == cells[4].text && cells[1].text == cells[7].text && cells[1].text != "")
        {
            UpdateScore(1);
            ResetGame();
        }

        if (cells[2].text == cells[5].text && cells[2].text == cells[8].text && cells[2].text != "")
        {
            UpdateScore(2);
            ResetGame();
        }

        //Diagonal
        if (cells[0].text == cells[4].text && cells[0].text == cells[8].text && cells[0].text != "")
        {
            UpdateScore(0);
            ResetGame();
        }

        if (cells[2].text == cells[4].text && cells[2].text == cells[6].text && cells[2].text != "")
        {
            UpdateScore(2);
            ResetGame();
        }
    }

    void CheckTie()
    {
        ResetGame();
    }

    void ResetGame()
    {
        foreach(TMP_Text cell in cells)
        {
            cell.text = "";
        }

        foreach(Button button in cellButtons)
        {
            button.gameObject.SetActive(true);
        }
    }

    void UpdateScore(int cell)
    {
        if (cells[cell].text == "X")
        {
            xScore++;
        }
        else
        {
            oScore++;
        }

        xPlayerNameText.text = xPlayerName + " " + xScore.ToString();
        oPlayerNameText.text = oPlayerName + " " + oScore.ToString();

        ResetGame();
    }
}
