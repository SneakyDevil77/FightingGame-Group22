using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CSelectIconDisplay : MonoBehaviour
{
    public CharacterCell character;

    public TMP_Text nameText;
    public Image characterIcon;

    private RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        rt = characterIcon.GetComponent<RectTransform>();


        nameText.text = character.name;

        characterIcon.sprite = character.art;
        rt.sizeDelta *= character.zoom;
        characterIcon.transform.Translate(0,-character.posadjust,0);
    }

}
