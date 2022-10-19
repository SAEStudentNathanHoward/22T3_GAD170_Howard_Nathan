using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivitiesWeek04 : MonoBehaviour
{
    private int yearInput;

    [SerializeField] private GameObject UIYearInput;
    [SerializeField] private GameObject ResultString;
    
    private bool calculate = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        calculate = Input.GetKeyDown(KeyCode.Return);
        
        if (calculate == true)
        {
            //yearInput = UIYearInput.
        }
    }
}
