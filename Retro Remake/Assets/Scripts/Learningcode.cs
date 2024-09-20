using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learningcode
: MonoBehaviour
{
    public int numberOfItems, score;    // Ints represent WHOLE NUMBERS
    public float health, weight, speed; // Ints represent DECIMAL NUMBERS
    public string menuLabel, dialogue, characterName;   // Strings represent WORDS/PHRASES/TEXT
    public bool isEnemyDead, isEffectActive, isGrounded, isPlayerDead;   // Btools represent values are TRUE OR FALSE
    public Vector2 size, playerLocation;    // Vestor2s represent 2-DIMENSIONAL DECIMALS
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Derek's favorite student is" + characterName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
