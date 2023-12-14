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

    void CheckWin()
    {

    }

    void ResetGame()
    {
        foreach(TMP_Text cell in cells)
        {
            cell.gameObject.SetActive(false);
        }

        foreach(Button button in cellButtons)
        {
            button.gameObject.SetActive(true);
        }
    }
}
