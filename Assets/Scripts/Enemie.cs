using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    int hp=5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp--;
            if (hp == 0)
            {
                Destroy(gameObject);
                GameController.Ins.IncreScore();
            }
        }
        else if (collision.gameObject.CompareTag("Respawn"))
        {
            Destroy(gameObject);
        }
    }
}
