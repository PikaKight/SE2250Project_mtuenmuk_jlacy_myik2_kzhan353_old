using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
  public static GameManager instance;
  private void Awake(){
    instance = this;
    SceneManager.sceneLoaded += LoadState;
  }

  //resources
  public List<Sprite> playerSprites;
  public List<Sprite> weaponSprites;

  public List<Sprite> xpTable;

  //references
  public Player_Knight Player;
  
  //public weapon?..

  //logic
  public int coins;
  public int experience;

  //save state
  public void SaveState (){
    Debug.Log("SaveState");
  }

  public void LoadState (Scene s, LoadSceneMode mode){
    SceneManager.sceneLoaded -= LoadState;
    Debug.Log("LoadState");
  }
  
}
