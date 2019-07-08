using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
            GameControler.instance.setScore(GameControler.instance.scoreQuantity + 1000);
            this.gameObject.SetActive(false);
        
    }
}
