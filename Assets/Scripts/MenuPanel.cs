using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
    public void startGame()
    {
        GameControler.instance.startFromMainMenu();
    }

    public void exitGame()
    {
        Application.Quit();
    }
}