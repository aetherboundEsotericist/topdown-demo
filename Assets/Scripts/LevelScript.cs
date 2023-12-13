using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelScript : MonoBehaviour 
{
    public int experience;
    public int experienceTolevelUp = 750;
    public int Level
    {
        get { return experience / experienceTolevelUp; }
        
    }
}