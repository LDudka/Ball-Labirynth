using UnityEngine;
using System.Collections;
using TMPro;

public class HudControler : MonoBehaviour
{
    public GameObject health;
    public TextMeshProUGUI score;
    public TextMeshProUGUI xPositon;
    public TextMeshProUGUI yPositon;

    public void setBoardPosition(float xPositon, float yPositon)
    {
        if (xPositon > 180)
        {
            this.xPositon.text = "X=" + ((int)xPositon-360).ToString();
        }
        else
        {
            this.xPositon.text = "X=" + ((int)xPositon).ToString();
        }

        if (yPositon > 180)
        {
            this.yPositon.text = "Y=" + ((int)yPositon-360).ToString();
        }
        else
        {
            this.yPositon.text = "Y=" + ((int)yPositon).ToString();
        }
    }

    public void setScoreText(int scoreCount)
    {
        score.text = scoreCount.ToString();
    }

    public void setHealth(int healthCount)
    {
        int i = 0;
        for (; i < healthCount; i++)
        {
            health.transform.GetChild(i).gameObject.SetActive(true);
        }
        for (; i < 5; i++)
        {
            health.transform.GetChild(i).gameObject.SetActive(false);
        }

        /*
        switch (healthCount)
        {
            case 0:
                health.transform.GetChild(0).gameObject.SetActive(false);
                health.transform.GetChild(1).gameObject.SetActive(false);
                health.transform.GetChild(2).gameObject.SetActive(false);
                health.transform.GetChild(3).gameObject.SetActive(false);
                health.transform.GetChild(4).gameObject.SetActive(false);
                break;
            case 1:
                health.transform.GetChild(0).gameObject.SetActive(true);
                health.transform.GetChild(1).gameObject.SetActive(false);
                health.transform.GetChild(2).gameObject.SetActive(false);
                health.transform.GetChild(3).gameObject.SetActive(false);
                health.transform.GetChild(4).gameObject.SetActive(false);
                break;
        }
        */
    }
}
