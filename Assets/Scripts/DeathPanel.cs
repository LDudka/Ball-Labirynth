using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathPanel : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public Text nickText;

    public Image background;

    public TextMeshProUGUI victoryOrDie;

    public void deathStyle()
    {
        this.background.color = new Color(0.2235294f, 0, 0, 0.5882353f);
        this.victoryOrDie.text = "YOU DIED";
    }

    public void wonStyle()
    {
        this.victoryOrDie.text = "YOU WON";
        this.background.color = new Color(0.8811617f, 1, 0, 0.5882353f);
    }

    public void addScore()
    {
        //GameControler.instance.scoresRef.scoreList.Add(
        //         new ScoresSave.Score(nickText.text.Length>0 ? nickText.text : "NoName" , GameControler.instance.scoreQuantity));

        if (nickText.text.Length > 0)
        {
            GameControler.instance.scoresRef.scoreList.Add(
                new ScoresSave.Score(nickText.text, GameControler.instance.scoreQuantity));
        }
        else
        {
            GameControler.instance.scoresRef.scoreList.Add(
                new ScoresSave.Score("UNKNOWN", GameControler.instance.scoreQuantity));
        }

    }


    public void backToMenu()
    {
        addScore();
        GameControler.instance.state = GameControler.State.MENU;
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }

    public void playAgain()
    {
        addScore();
        GameControler.instance.startFromMainMenu();
    }

    public void setScoreText()
    {
        scoreText.text = "SCORE: " + GameControler.instance.scoreQuantity.ToString();
    }

    public void OnEnable()
    {
        setScoreText();
    }
}
