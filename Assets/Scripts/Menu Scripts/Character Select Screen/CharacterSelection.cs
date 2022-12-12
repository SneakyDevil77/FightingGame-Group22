using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] P1Characters;
    [SerializeField] private GameObject[] P2Characters;
    [SerializeField] private GameObject[] P1CBorder;
    [SerializeField] private GameObject[] P2CBorder;

    public GameObject firstcharacteroption;

    public int selectedCharacter = 0;
    public int P2selectedCharacter = 0;
    bool player1Ready = false;
    bool player2Ready = false;


    void Start() 
    {

    }



    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            NextCharacter();
        }
    }

    public void setfirstoption()
    {
        //clear Eventsystem Current Selection
         EventSystem.current.SetSelectedGameObject(null);
        //Set new selected option
        EventSystem.current.SetSelectedGameObject(firstcharacteroption);
    }

    public void NextCharacter()
    {
        P1Characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % P1Characters.Length;
        P1Characters[selectedCharacter].SetActive(true);
        
        P1CBorder[selectedCharacter-1].SetActive(false);
        P1CBorder[selectedCharacter].SetActive(true);
    }

    public void PrevCharacter()
    {
        P1Characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += P1Characters.Length;
        }
        P1Characters[selectedCharacter].SetActive(true);

        P1CBorder[selectedCharacter+1].SetActive(false);
        P1CBorder[selectedCharacter].SetActive(true);
    }
    
    public void P2NextCharacter()
    {
        P2Characters[P2selectedCharacter].SetActive(false);
        P2selectedCharacter = (P2selectedCharacter + 1) % P2Characters.Length;
        P2Characters[P2selectedCharacter].SetActive(true);

        P2CBorder[P2selectedCharacter-1].SetActive(false);
        P2CBorder[P2selectedCharacter].SetActive(true);
    }

    public void P2PrevCharacter()
    {
        P2Characters[P2selectedCharacter].SetActive(false);
        P2selectedCharacter--;
        if (P2selectedCharacter < 0)
        {
            P2selectedCharacter += P2Characters.Length;
        }
        P2Characters[P2selectedCharacter].SetActive(true);

        P2CBorder[P2selectedCharacter+1].SetActive(false);
        P2CBorder[P2selectedCharacter].SetActive(true);
    }

    public void P1CharacterSelect()     //Maybe combine into one
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        player1Ready = true;
        StartGame();

    }

    public void P2CharacterSelect()
    {
        PlayerPrefs.SetInt("P2selectedCharacter", P2selectedCharacter);
        player2Ready = true;
        StartGame();
    }

    public void StartGame()
    {
        if (player2Ready == true && player1Ready == true)
        {
            SceneManager.LoadScene(1);
        }
        else 
        {
            return;
        }
    }


}
