using System;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] private bool hasFallen;

    private void OnTriggerEnter(Collider other)
    {
        if (hasFallen)
        {
            return;
        }
        if (other.GetComponent<FallenWallDetector>())
        {
            hasFallen = true;
            GameManager.instance.BrickFallen();
        }
    }
}
