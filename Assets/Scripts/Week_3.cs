using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My Name Is Raymond");
    }

    void powerLevel()
    {
        int strength = 5;
        int agility = 5;
        int intelligence = 5;

        float totalStats = (float)((strength * 2) + agility * 1.5 + intelligence);

    }


}
