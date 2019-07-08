using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(GameControler.instance.state==GameControler.State.GAME)
        {
            this.win();
        }
    }

    public void win()
    {
        GameControler.instance.state = GameControler.State.DYING;
        GameControler.instance.deathController.deathPanel.GetComponent<DeathPanel>().wonStyle();
        GameControler.instance.deathController.deathPanel.SetActive(true);
    }

}
