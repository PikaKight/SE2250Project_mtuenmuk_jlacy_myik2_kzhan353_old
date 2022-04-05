using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //commented out old camera code -> replacing with different version
    //public GameObject player;

    public Transform lookAt;
    public float boundX = 0.3f;
    public float boundY = 0.15f;

    // Update is called once per frame AFTER all other process
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        
        //checks if player is inside the bounds on the x-axis
        float deltaX = lookAt.position.x - transform.position.x;
        if (deltaX > boundX || deltaX < -boundX){
            if (transform.position.x < lookAt.position.x){
                delta.x = deltaX - boundX;
            }
            else{
                delta.x = deltaX + boundX;
            }
        }
        float deltaY = lookAt.position.y - transform.position.y;
         //checks if player is inside the bounds on the y-axis
          if (deltaY > boundY || deltaY < -boundY){
            if (transform.position.y < lookAt.position.y){
                delta.y = deltaY - boundY;
            }
            else{
                delta.y = deltaY + boundY;
            }
        }
        //move camera
        transform.position += new Vector3(delta.x,delta.y,0);

        
        //Vector3 pos = player.transform.position;
        //transform.position = new Vector3 (pos.x, pos.y, -10);
    }
}
