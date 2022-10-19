using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace NathanHoward 
{
    public class ActivitiesWeek02 : MonoBehaviour
    {
        // Declaration and Assigning of variables
        [Header("Favourite Game")]
        [SerializeField] private string favouriteGame = "Destiny 2";

        [Header("Hours Played")]
        [SerializeField] private float hoursPlayed = 735f;

        [Header("Game Cost")]
        [SerializeField] private float gameCost = 600f;
        private int gameValuePerHR;

        private float tempValue;

        // Creation of the character Stats
        private int strength;
        private int agility;
        private int intelligence;
        private bool isKeyPress = false;
        private int statpool = 20;

        // Creation of the variable for coin flip
        private int coinFlip;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My Favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed + " hours, and it cost me " + gameCost + ". Therefore, my value of dollars per hour is: " + gameCost / hoursPlayed + ".");

            // Assigning tempValue to be a random number between 0 and 10
            tempValue = Random.Range(0, 10);

            // if statements for testing tempValue
            if (tempValue == 1)
            {
                Debug.Log("The number is exactly one.");
            }
            if (tempValue > 3)
            {
                Debug.Log("The number is greater than three.");
            }
            if (tempValue < 3 && tempValue > 5)
            {
                Debug.Log("The number was less than three or greater than five.");
            }
            if (tempValue > 1 && tempValue < 5)
            {
                Debug.Log("The number was greater than one and less than five.");
            }
            else if (tempValue > 5)
            {
                Debug.Log("The number was greater than five.");
            }

            // Simulating the flipping the coin
            coinFlip = Random.Range(0, 1);
            if (coinFlip == 0)
            {
                Debug.Log("The coin flip was heads");
            }
            else
            {
                Debug.Log("The coin flip was tails");
            }
        }
        private void Update()
        {
            // Setting spacebar to control stat generation
            isKeyPress = Input.GetButtonDown("Jump");

            // Checking if spacebar is pressed
            if (isKeyPress == true)
            {
                // Randomly assigning stats a value between 0 and 20
                statpool = 20;
                strength = Random.Range(0, statpool);
                statpool = statpool - strength;
                agility = Random.Range(0, statpool);
                statpool = statpool - agility;
                intelligence = Random.Range(0, statpool);
                statpool = statpool - intelligence;

                // Debugging out stat values
                Debug.Log("Strength stat = " + strength);
                Debug.Log("Agility stat = " + agility);
                Debug.Log("Intellegence stat = " + intelligence);
                Debug.Log("Current statpool = " + statpool);
            }

        }
    }

}