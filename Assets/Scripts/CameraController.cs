using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{   
    public Transform target;
    public Transform farBackGround, middleBackGround;

    //private float lastXPosition;
    private Vector2 lastPos;
    public float minHeight, maxHeight;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(target.position.x , target.position.y,transform.position.z);

        //float clampedY = Mathf.Clamp(transform.position.y,minHeight,maxHeight);
        //transform.position = new Vector3(transform.position.x,clampedY,transform.position.z);

        transform.position = new Vector3(target.position.x,Mathf.Clamp(target.position.y,minHeight,maxHeight),transform.position.z);

        //float amountToMoveX = transform.position.x - lastXPosition;
        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x,transform.position.y - lastPos.y);

        //farBackGround.position = farBackGround.position + new Vector3(amountToMove.x,amountToMove.y,0f);
        middleBackGround.position += new Vector3(amountToMove.x,amountToMove.y,0f)* 0.88f;

        lastPos = transform.position;



    }
}
