using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text TextscoreText;
    [SerializeField] private string preText;
    private int score = 0;

    private void UpdateText()
    {
        TextscoreText.text = preText + " " + score.ToString();
    }

    public void Add() 
    {
        score++;
        UpdateText();
        if(score == 5) 
        {
        
        }
    }
}
