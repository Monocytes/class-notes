using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //creating array

    //int[] playerHealth = new int[5];
    //int[] playerHealthTwo = { 50, 59, 675, 6, 43, 45, 67, 87 };


    public int[] playerHealth;
    public GameObject[] players;
   


    // Use this for initialization

    void Start()
    {
        /* playerHealth[0] = 100;
         playerHealth[1] = 140;
         playerHealth[2] = 100;
         playerHealth[3] = 90;
         playerHealth[4] = 70;

         Debug.Log(playerHealthNew[5]); */


        //Debug.Log("Player Health Length is " + playerHealth.Length);


        Debug.Log("Showing Players' Names and its Health");

        //for loop practice

      

        //DisablePlayers();


    }







    void Update()
    {
        /*
         * For playerHealth Array practice
         * 
         * if (Input.GetKeyDown(KeyCode.Keypad1))
            Debug.Log(playerHealth[0]);

        if (Input.GetKeyDown(KeyCode.Keypad2))
            Debug.Log(playerHealth[1]);

        if (Input.GetKeyDown(KeyCode.Keypad3))
            Debug.Log(playerHealth[2]);

        if (Input.GetKeyDown(KeyCode.Keypad4))
            Debug.Log(playerHealth[3]);

        if (Input.GetKeyDown(KeyCode.Keypad5))
            Debug.Log(playerHealth[4]);
            */

        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangePlayer(0);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangePlayer(1);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangePlayer(2);

        if (Input.GetKeyDown(KeyCode.Alpha4))
            ChangePlayer(3);

        if (Input.GetKeyDown(KeyCode.Alpha5))
            ChangePlayer(4);

        if (Input.GetKeyDown(KeyCode.Alpha6))
            ChangePlayer(5);

    }

    void ChangePlayer(int playerNumber)
    {

        DisablePlayers();
        players[playerNumber].SetActive(true);
        Debug.Log("Player " + players[playerNumber].name + " is engaged. Health is " + playerHealth[playerNumber]);

    }

    void DisablePlayers()
    {
        for (int i = 0; i < players.Length; i++)   //for loops, try not using hard-coded numbers, so the code is more 
        {
            players[i].SetActive(false);
            Debug.Log("Player " + players[i].name + " is disengaged");
        }
    }
}