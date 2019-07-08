using UnityEngine;
using System.Collections;

public class DeathController : MonoBehaviour
{
    public GameObject deathPanel;
    public CheckPoint currentCheckPoint;

    IEnumerator deathEnumerator(Hole hole)
    {
        yield return new WaitForSeconds(3);
        GameControler.instance.board.GetComponent<Collider>().enabled = true;
        hole.GetComponent<Collider>().enabled = true;
        if (GameControler.instance.healthQuantity<=0)
        {
            deathPanel.GetComponent<DeathPanel>().deathStyle();
            deathPanel.SetActive(true);
        }
        else
        {
            currentCheckPoint.spawnBall();
        }
    }


    public void startDeath(Hole hole)
    {
        GameControler.instance.state = GameControler.State.DYING;
        StartCoroutine(deathEnumerator(hole));
    }


    //2-3 sekubndy
    //przywrocić collider dziury i planszy
    //gdy nie ma zycia UI game over
    //gdy jest zycie respawn w checkPoincie

}
