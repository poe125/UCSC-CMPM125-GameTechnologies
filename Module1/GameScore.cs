using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameScore : MonoBehaviour
{
    int Gscore = 0;
    public MainCharacter mainCharacter;
    public TMP_Text gameScore;

    void Update()
    {
        Gscore = mainCharacter.score;
        gameScore.text = Gscore.ToString(); 
    }
}
