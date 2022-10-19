using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NathanHoward
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject coinPrefab;

        [SerializeField] private Camera mainCamera;

        void Start()
        {
            SpawnCoin();
            SpawnCoin();
        }

        void SpawnCoin()
        {
            int xPosition = Random.Range(-50, 50);
            int yPosition = Random.Range(-50, 50);
            int zPosition = Random.Range(-50, 50);

            //mainCamera.ViewportToWorldPoint(Vector3 position);

            Instantiate(coinPrefab, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
        }
        
    }
}
