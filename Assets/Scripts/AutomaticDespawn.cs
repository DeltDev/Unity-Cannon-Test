using System;
using System.Collections;
using UnityEngine;

public class AutomaticDespawn : MonoBehaviour
{
    [SerializeField] private float despawnTime = 5f;

    private void Start()
    {
        StartCoroutine(DelayedDespawn(despawnTime));
    }

    void DespawnObject()
    {
        Destroy(gameObject);
    }

    IEnumerator DelayedDespawn(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        DespawnObject();
    }
}
