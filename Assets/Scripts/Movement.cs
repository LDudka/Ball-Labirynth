using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameControler.instance.state != GameControler.State.MENU)
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            if (GameControler.instance.board == null)
                return; 
            Transform board = GameControler.instance.board;
            Rigidbody boardRigid = board.GetComponent<Rigidbody>();

            if (vertical != 0 || horizontal != 0)
            {
                boardRigid.angularVelocity = new Vector3(vertical, 0, -horizontal);

                float paramVertical = board.localEulerAngles.x;

                if (paramVertical > 180 && paramVertical < 330 && vertical<0)
                {
                    boardRigid.angularVelocity = new Vector3(0, boardRigid.angularVelocity.y, boardRigid.angularVelocity.z);
                }
                if (paramVertical > 30 && paramVertical < 180 && vertical > 0)
                {
                    boardRigid.angularVelocity = new Vector3(0, boardRigid.angularVelocity.y, boardRigid.angularVelocity.z);
                }

                float paramHorizontal = board.localEulerAngles.z;

                if (paramHorizontal > 180 && paramHorizontal < 330 && horizontal > 0)
                {
                    boardRigid.angularVelocity = new Vector3(boardRigid.angularVelocity.x, boardRigid.angularVelocity.y, 0);
                }
                if (paramHorizontal > 30 && paramHorizontal < 180 && horizontal < 0)
                {
                    boardRigid.angularVelocity = new Vector3(boardRigid.angularVelocity.x, boardRigid.angularVelocity.y, 0);
                }
            }
            else
            {
                boardRigid.angularVelocity = Vector3.zero;
            }

            board.localEulerAngles =
                  new Vector3(board.localEulerAngles.x, 0, board.localEulerAngles.z);

            GameControler.instance.hudControler.setBoardPosition(board.localEulerAngles.x, board.localEulerAngles.z);
                
        }


        //if (GameControler.instance.state != GameControler.State.MENU)
        //{
        //    float vertical = Input.GetAxis("Vertical");
        //    float horizontal = Input.GetAxis("Horizontal");

        //    Transform board = GameControler.instance.board;

        //    if (vertical != 0)
        //    {
        //        float param = board.localEulerAngles.x + Time.deltaTime * 50 * vertical;

        //        //board.Rotate(new Vector3(1, 0, 0), Time.deltaTime * 50 * vertical);

        //        if (param <= 30 || param >= 330)
        //        {
        //            board.localEulerAngles =
        //                new Vector3(param, board.localEulerAngles.y, board.localEulerAngles.z);
        //        }
        //        else if (param > 30 && param < 180)
        //        {
        //            board.localEulerAngles =
        //                new Vector3(30, board.localEulerAngles.y, board.localEulerAngles.z);
        //        }
        //        else
        //        {
        //            board.localEulerAngles =
        //                new Vector3(330, board.localEulerAngles.y, board.localEulerAngles.z);
        //        }
        //    }
        //    if (horizontal != 0)
        //    {
        //        float param = board.localEulerAngles.z - Time.deltaTime * 50 * horizontal;
        //        if (param <= 30 || param >= 330)
        //        {
        //            board.localEulerAngles =
        //                new Vector3(board.localEulerAngles.x, board.localEulerAngles.y, param);
        //        }
        //        else if (param > 30 && param < 180)
        //        {
        //            board.localEulerAngles =
        //                new Vector3(board.localEulerAngles.x, board.localEulerAngles.y, 30);
        //        }
        //        else
        //        {
        //            board.localEulerAngles =
        //                new Vector3(board.localEulerAngles.x, board.localEulerAngles.y, 330);
        //        }
        //    }
        //}
    }
}
