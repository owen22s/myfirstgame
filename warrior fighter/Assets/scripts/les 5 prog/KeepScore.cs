using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeepScore : MonoBehaviour
{
    private TMP_Text scoreField;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        score = 0;
        scoreField.text = "" + score;
    }

    // Method to add score
    public void AddScore(int add)
    {
        score += add;
        scoreField.text = "" + score;
    }
}

