using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextUpdater : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public ScoreController scoreController;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreController.OnScoreChanged.AddListener(UpdateScoreText);
        
    }

    // Update is called once per frame
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + scoreController.Score.ToString();
    }
}
