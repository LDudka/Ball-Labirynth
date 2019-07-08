using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour
{
    public Transform spawnPoint, mesh;
    bool animationPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        GameControler.instance.deathController.currentCheckPoint = this;
        if(animationPlayed==false)
        {
            StartCoroutine(moveMesh());
        }
    }

    IEnumerator moveMesh()
    {
        animationPlayed = true;
        while(mesh.localPosition.y > -0.95f)
        {
            mesh.localPosition = new Vector3(mesh.localPosition.x,
                mesh.localPosition.y - 0.05f,
                mesh.localPosition.z);
            yield return null;
        }
    }

    public void spawnBall()
    {
        GameControler.instance.board.localRotation = Quaternion.identity;
        GameControler.instance.decrementHealth();

        var rigid= GameControler.instance.ball.GetComponent<Rigidbody>();
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        GameControler.instance.ball.localRotation = Quaternion.identity;
        GameControler.instance.ball.position = spawnPoint.position;

        GameControler.instance.state = GameControler.State.GAME;
    }

    //triger
    //referencja do triggera
    //odjac zycie i odswiezyc HUD
    //wyzerowac rotacje planszy
    
    //zespawnowac kulke

}
