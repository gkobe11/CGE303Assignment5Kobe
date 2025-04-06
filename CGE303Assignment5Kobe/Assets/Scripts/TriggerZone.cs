using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//text mesh pro
using TMPro;

public class TriggerZone : MonoBehaviour
{
    //set to reference in inspector
    public TMP_Text output;

    //enter text to display in inspector
    public string textToDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //set player tag on player in inspector
        if (collision.gameObject.tag == "Player")
        {
            //display "You Win!" on screen
            output.text = textToDisplay;
        }
        //Debug.Log("Triggered by: " + collision.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
