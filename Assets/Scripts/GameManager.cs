using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Android.Types;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject apple;
    public float maxX;
    public float spawnRate;
    public Transform spawnPoint;
    public TextMeshProUGUI scoreText;

    public int score { get; set; }

    private void Start()
    {
        Instance = this;
        StartSpawning();
    }
    // Update is called once per frame
    void Update()
    {

        scoreText.text = score.ToString();
    }

    private void StartSpawning()
    {
        Invoke("SpawnApple", spawnRate);
    }

    private void SpawnApple()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(apple, spawnPos, Quaternion.identity);

        Invoke("SpawnApple", spawnRate);
    }

}
