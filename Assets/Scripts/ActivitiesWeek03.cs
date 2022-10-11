using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivitiesWeek03 : MonoBehaviour
{
    [SerializeField] private float currentPorridgeTemperature = 85f;

    private float hotLimitTemperature = 70f;
    private float coldLimitTemperature = 40f;

    [Header("Name")]
    [SerializeField] private string firstName;
    [SerializeField] private string lastName;

    [Header("Player 1 Stats")]
    [SerializeField] private int p1Strength;
    [SerializeField] private int p1Agility;
    [SerializeField] private int p1Intellegance;

    [Header("Player 2 Stats")]
    [SerializeField] private int p2Strength;
    [SerializeField] private int p2Agility;
    [SerializeField] private int p2Intellegance;

    private float p1PowerLevel;
    private float p2PowerLevel;

    [Header("Pie Splitter Variables")]
    [SerializeField] private int pieSlices;
    [SerializeField] private int numberOfPeople;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        currentPorridgeTemperature -= Time.deltaTime * 2f;
    }

    private void TemperatureTest()
    {
        if (currentPorridgeTemperature > hotLimitTemperature)
        {
            Debug.Log("The porridge is too hot " + (int)currentPorridgeTemperature);
        }
        else if (currentPorridgeTemperature < coldLimitTemperature)
        {
            Debug.Log("The porridge is too cold " + (int)currentPorridgeTemperature);
        }
        else if (currentPorridgeTemperature == 55f)
        {
            Debug.Log("The porridge is 55C " + (int)currentPorridgeTemperature );
        }
        else
        {
            Debug.Log("The porridge is just right " + (int)currentPorridgeTemperature) ;
        }
    }

    private void PrintName()
    {
        Debug.Log("My name is" + firstName + " " + lastName);
    }

    private void PowerLevel()
    {
        p1PowerLevel = (float)(p1Strength * 2 + p1Agility * 1.5 + p1Intellegance);
        Debug.Log(p1PowerLevel);
        p2PowerLevel = (float)(p2Strength * 2 + p2Agility * 1.5 + p2Intellegance);
        Debug.Log(p2PowerLevel);
    }

    private void PowerFight()
    {
        if (p1PowerLevel > p2PowerLevel)
        {
            Debug.Log("The winner is Player 1!");
            Debug.Log("Player 1 had " + p1PowerLevel + " power level.");
            Debug.Log("Player 2 had " + p2PowerLevel + " power level.");
            Debug.Log("The winner won by " + (p1PowerLevel / p2PowerLevel) + "%");
        }
        else if (p1PowerLevel == p2PowerLevel)
        {
            Debug.Log("It is a draw!");
        }
        else if (p1PowerLevel < p2PowerLevel)
        {
            Debug.Log("The winner is Player 2!");
            Debug.Log("Player 1 had " + p1PowerLevel + " power level.");
            Debug.Log("Player 2 had " + p2PowerLevel + " power level.");
            Debug.Log("The winner won by " + (p1PowerLevel / p2PowerLevel) + "%");
        }
    }

    private void SplitPie()
    {
        
    }
}
