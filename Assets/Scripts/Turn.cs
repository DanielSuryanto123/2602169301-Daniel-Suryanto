using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Turn : MonoBehaviour
{
    Text mytext;
  
    void Start()
    {
        mytext= GetComponent<Text>();
        mytext.text = "Game Start";
        GameManager.instance.message += UpdateMessage;
    }

    void UpdateMessage(Player player)
    {
        mytext.text = GameManager.instance.hasGameFinished ? "GAME OVER" :player.ToString() + "'s Turn";
    }
}
