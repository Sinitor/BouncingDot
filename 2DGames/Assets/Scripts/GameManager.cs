using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoretext;
    public  int score;

    private void Update()
    {
        if (score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score); 
        } 
        scoretext.text = "SCORE: " + score; 
    }  

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
