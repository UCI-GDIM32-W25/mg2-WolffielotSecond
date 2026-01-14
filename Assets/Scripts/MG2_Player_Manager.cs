using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MG2_Player_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text UI_Score;
    [SerializeField] private MG2_Coin coin;
    private float score;
    private float timer = 1.5f;
    private float CacheTimer;
    private void Start()
    {
        CacheTimer = timer;
    }
    public void _addScore(int score)
    {
        this.score += score;
        UI_Score.text = "SCORE: " + this.score.ToString();
    }
    private void Spawn_Coin()
    {
        Instantiate(coin, new Vector3(16f, 13f, 0f), Quaternion.identity);
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Spawn_Coin();
            if (CacheTimer > 0.5f)
            {
                timer = Random.Range(0.2f, 1.25f);
                CacheTimer = timer;
            }
            else
            {
                timer = Random.Range(1.0f, 1.5f);
                CacheTimer = timer;
            }
        }
    }
}
