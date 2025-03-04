using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<GameObject> wallGroupList;
    public int fallenBricksAmount, fallenBricksRequired;
    public TextMeshProUGUI statusMessage,scoreText;
    public Transform wallSpawnPoint;
    private GameObject chosenWallGroup;
    private void Awake()
    {
        statusMessage.text = "";
        instance = this;
    }

    private void Start()
    {
        chosenWallGroup = wallGroupList[Random.Range(0, wallGroupList.Count)];
        Instantiate(chosenWallGroup, wallSpawnPoint.position, Quaternion.identity);
        fallenBricksRequired = chosenWallGroup.GetComponentsInChildren<Brick>().Length;
    }

    public void BrickFallen()
    {
        fallenBricksAmount++;
        if (fallenBricksAmount >= fallenBricksRequired)
        {
            statusMessage.text = "You Win!";
        }
    }

    private void Update()
    {
        scoreText.text = fallenBricksAmount.ToString() + "/" + fallenBricksRequired.ToString();
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
