using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{
  public Player player;

  private void OnTriggerEnter(Collider other){
      if(other.CompareTag("Player")){
          player.FindFriend();
      }
  }
}
