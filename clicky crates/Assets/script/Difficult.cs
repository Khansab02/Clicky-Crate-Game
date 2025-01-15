using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Difficult : MonoBehaviour
{
    private Button button;
    private GameManager gamemanager;
    public int difficulty;

    void Start()
    {
        gamemanager=GameObject.Find("GameManager").GetComponent<GameManager>();
        button=GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
            }

    // Update is called once per frame
    void SetDifficulty()
    {
        gamemanager.startgame(difficulty);
    }
}
