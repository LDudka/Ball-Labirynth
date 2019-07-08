using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    public enum State
    {
        MENU,
        GAME,
        DYING
    };

    public int healthQuantity;

    public int scoreQuantity;

    public ScoresSave scoresRef;

    public HudControler hudControler;

    public DeathController deathController;

    public Transform ball;

    public static GameControler instance = null;

    public Transform board;

    public State state;

    public void startFromMainMenu()
    {
        GameControler.instance.state = GameControler.State.GAME;
        StartCoroutine(loadGameScene());

        //SceneManager.LoadScene("GameScene");
    }

    IEnumerator loadGameScene()
    {
        var wait = SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
        while (!wait.isDone)
        {
            yield return null;
        }
        yield return null;
        newGame();
    }

    public void newGame()
    {
        healthQuantity = 3;
        scoreQuantity = 0;
        hudControler.setHealth(healthQuantity);
        hudControler.setScoreText(scoreQuantity);
    }

    public void decrementHealth()
    {
        healthQuantity--;
        hudControler.setHealth(healthQuantity);
    }

    public void setScore(int value)
    {
        scoreQuantity = value;
        hudControler.setScoreText(value);
    }

    public void setHealth(int value)
    {
        healthQuantity = value;
        hudControler.setHealth(healthQuantity);
    }

    private void Awake()
    {
        if(instance!=null)
        {
            instance.board = this.board;
            instance.hudControler = this.hudControler;
            instance.deathController = this.deathController;
            instance.ball = this.ball;
            DestroyImmediate(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    public GameControler getInstance()
    {
        return instance;
    }
}
