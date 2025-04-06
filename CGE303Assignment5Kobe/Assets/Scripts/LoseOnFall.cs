using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{
    public float lowestY; //set in inspector

  
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowestY)
        {
            //lose
            ScoreManager.gameOver = true;
        }
    }
}
