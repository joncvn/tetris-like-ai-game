using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public UnityEvent OnScoreChanged;
    public int Score { get; private set; }
   
    public void AddScore(int linesCleared)
    {
        int points = 0;
        switch (linesCleared)
        {
            case 1: points = 40; break;
            case 2: points = 100; break;
            case 3: points = 300; break;
            case 4: points = 1200; break;
            default: break;
        }
        Score += points;
        OnScoreChanged.Invoke();
    }

    public void ResetScore()
    {
        Score = 0;
        OnScoreChanged.Invoke();
    }
}
