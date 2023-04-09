using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    int hp=5;
    GameController m_gamecontroller;
    private void Start()
    {
        m_gamecontroller = FindAnyObjectByType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp--;
            if (hp == 0)
            {
                Destroy(gameObject);
                m_gamecontroller.IncreScore();
            }
        }
        else if (collision.gameObject.CompareTag("Respawn"))
        {
            Destroy(gameObject);
        }
    }
}
