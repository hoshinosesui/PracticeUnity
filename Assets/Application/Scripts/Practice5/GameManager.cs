using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargets());
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTargets()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);

            //UpdateScore(5);
        }
    }
    
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
