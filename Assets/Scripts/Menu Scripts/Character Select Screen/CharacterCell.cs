using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character" )]
public class CharacterCell : ScriptableObject
{

    public new string name;
       
    public Sprite art;

    public int attackpower;
    public int knockbacktaken;
    public float zoom = 1;
    public float posadjust = 1;

}
