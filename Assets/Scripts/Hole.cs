using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (GameControler.instance.state == GameControler.State.GAME)
        {
            GameControler.instance.board.GetComponent<Collider>().enabled = false;
            transform.GetComponent<Collider>().enabled = false;
            GameControler.instance.deathController.startDeath(this);
        }
    }
}
