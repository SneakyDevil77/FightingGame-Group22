using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections.Specialized;

public class HUD : MonoBehaviour
{
    public Sprite[] charactersprites;
    public GameObject[] characterprefabs;
    public Image P1image;
    public Image P2image;
    public TMP_Text P1name;
    public TMP_Text P2name;
    public TMP_Text rNumber;
    
    private int selectedCharacter;
    private int P2selectedCharacter;

    private float roundNumber;
    

    // Start is called before the first frame update
    void Start()
    {    
        roundNumber = RoundManager.roundsleft;    
        setSprites();
        setnames();
        displayroundNumber();
        
    }

    private void displayroundNumber()
    {
        rNumber.text = "Round: " + roundNumber;
    }

    private void setSprites()
    {
        selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        P2selectedCharacter = PlayerPrefs.GetInt("P2selectedCharacter");
        P1image.sprite = charactersprites[selectedCharacter];
        P2image.sprite = charactersprites[P2selectedCharacter];      
    }

    private void setnames()
    {
        selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        P2selectedCharacter = PlayerPrefs.GetInt("P2selectedCharacter");
        P1name.text = "Player 1: " + characterprefabs[selectedCharacter].name;
        P2name.text = "Player 2: " + characterprefabs[P2selectedCharacter].name;      
    }

}
