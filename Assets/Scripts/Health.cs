using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(GameControler.instance.healthQuantity<5)
        {
            GameControler.instance.setHealth(GameControler.instance.healthQuantity+1);

            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}