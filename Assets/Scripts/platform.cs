using UnityEngine;

public class platform : MonoBehaviour
{
    gameManager gm;
    bool reached = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!reached)
        {
            gm = GameObject.Find("Game Manager").GetComponent<gameManager>();

            gm.GeneratePlatform();
            reached = true;
        }
        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (gm.player.transform.position.y > transform.position.y)
        {
            gm.deathHeight = transform.position.y;
            this.enabled = false;
        }
    }
}
