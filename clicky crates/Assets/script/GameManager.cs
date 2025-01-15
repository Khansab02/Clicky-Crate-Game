using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> resourse;
    public TextMeshProUGUI scoretext;
    int score = 0;
    public TextMeshProUGUI gameover;
    public bool isgame;
    public Button res;
    public GameObject titlescreen;
    private float spawnrate = 1.0f;


    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Updatescore(int scoretoadd)
    {
        score += scoretoadd;
        scoretext.text = "Score   " + score;
    }
    IEnumerator spawn()
    {
        while (isgame)
        {

            yield return new WaitForSeconds(spawnrate);
            int index = Random.Range(0, resourse.Count);
            Instantiate(resourse[index]);
        }
    }
    public void game()
    {

        gameover.gameObject.SetActive(true);
        isgame = false;
        res.gameObject.SetActive(true);

      
    }
    public void startgame(int difficulty)
    {
        isgame = true;
        res.gameObject.SetActive(false);
        spawnrate /= difficulty; 
        StartCoroutine(spawn());
        titlescreen.gameObject.SetActive(false);

    }
}
