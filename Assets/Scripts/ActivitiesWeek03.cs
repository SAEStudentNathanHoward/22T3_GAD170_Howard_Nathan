using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivitiesWeek03 : MonoBehaviour
{
    [SerializeField] private float currentPorridgeTemperature = 85f;

    private float hotLimitTemperature = 70f;
    private float coldLimitTemperature = 40f;

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
}
