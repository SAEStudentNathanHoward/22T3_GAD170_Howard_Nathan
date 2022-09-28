using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NathanHoward 
{
    public class ActivitiesWeek02 : MonoBehaviour
    {
        [Header("Favourite Game")]
        [SerializeField] private string favouriteGame = "Destiny 2";

        [Header("Hours Played")]
        [SerializeField] private float hoursPlayed = 735f;

        [Header("Game Cost")]
        [SerializeField] private float gameCost = 600f;
        
        private int gameValuePerHR;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My Favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed + " hours, and it cost me " + gameCost + ". Therefore, my value of dollars per hour is: " + gameCost / hoursPlayed + ".");
        }
    }

}