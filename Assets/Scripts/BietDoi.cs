using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BietDoi : MonoBehaviour
{
    public float moveSpeed;
    
    private void Start()
    {
        
        moveSpeed = 3;
    }
    private void Update()
    {
        EnemieMove();
        StopEnemie();
    }
    public void EnemieMove()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
    public void StopEnemie()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if (transform.position.x > max.x/3 )
        {
            moveSpeed = 0.3f;
        }  
    }
}
