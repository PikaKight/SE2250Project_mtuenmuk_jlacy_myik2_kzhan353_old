using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : Collidable
{

    //array containing the names of each scene/game-level
  public string[] sceneNames;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player_Knight"){
            //teleports the player to scene
            //string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            UnityEngine.SceneManagement.SceneManager.LoadScene("SecondFloor");
        }
    }
}
