using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZone : MonoBehaviour
{
    bool active = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (active && collision.gameObject.tag == "Player")
        {
            active = false;
            ScoreManager.score++;

            collision.gameObject.GetComponent<PlatformerPlayerController>().playCoinSound(); //play score sound

            //destroy trigger zone
            Destroy(gameObject);
        }
    }
}
