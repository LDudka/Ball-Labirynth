using UnityEngine;
using System.Collections;
using TMPro;

public class ScorePanel : MonoBehaviour
{
    public GameObject layout;

    public void OnEnable()
    {
        //string[] names = new string[3];
        //names[0] = "LukasZombie";
        //names[1] = "Seba Patus";
        //names[2] = "Swiniol";

        //int[] scores = new int[3];
        //scores[0] =25;
        //scores[1] = 36;
        //scores[2] = 87;

        GameControler.instance.scoresRef.scoreList.Sort(delegate (ScoresSave.Score x, ScoresSave.Score y)
        {
            if (x.pointsQuantity > y.pointsQuantity)
            {
                return -1;
            }
            else if (x.pointsQuantity < y.pointsQuantity)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        });

        int i = 0;
        for (; i < GameControler.instance.scoresRef.scoreList.Count && i < 10; i++)
        {
            layout.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = GameControler.instance.scoresRef.scoreList[i].nick;
            layout.transform.GetChild(i).GetChild(1).GetComponent<TextMeshProUGUI>().text = GameControler.instance.scoresRef.scoreList[i].pointsQuantity.ToString();
            layout.transform.GetChild(i).gameObject.SetActive(true);
        }
        for (; i < 10; i++)
        {
            layout.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
