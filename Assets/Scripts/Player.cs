using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] private float movespeed;
    public float spawnTime;
    float curSpawnTime;
    public Transform shootingPoint;
    private float m_movingLimitX;
    public AudioSource aus;
    public AudioClip shootingSound;
    public float MovingLimitX { get => m_movingLimitX; }
    // Start is called before the first frame update
    void Start()
    {
        curSpawnTime = spawnTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        SpawnBullet();
    }
    public void PlayerMove()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * movespeed * Time.deltaTime);   
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }
        m_movingLimitX = Helper.Get2DCamSize().x / 2;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -m_movingLimitX, m_movingLimitX),
            transform.position.y, transform.position.z);
    }
    public void SpawnBullet()
    {
        curSpawnTime = curSpawnTime - 0.1f*Time.deltaTime;
        if (curSpawnTime <= 0 && bullet && shootingPoint)
        {
            
            Instantiate(bullet,shootingPoint.position,Quaternion.identity);
            curSpawnTime = spawnTime;
            if(aus &&shootingPoint)
            {
                
                //aus.PlayOneShot(shootingSound);
            }
        }
    }
}
