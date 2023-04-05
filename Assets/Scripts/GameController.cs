using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : Singleton<GameController>
{
    int score;
    public TextMeshProUGUI killCounting;
    public GameObject hinhVuong;
    public GameObject hinhThoi;
    public GameObject tamGiac;
    public GameObject Hcn;
    public int spawnTime;
    int cur_Time;
    public int Score { get => score; set => score = value; }
    public void IncreScore()
    {
        score++;
    }

    // Start is called before the first frame update
    private void Awake()
    {
        cur_Time = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        killCounting.text = score.ToString();
        CreatEnemie();
    }
    public void CreatEnemie()
    {
        cur_Time--;
        if (cur_Time ==12000)
        {
            Instantiate(hinhVuong, transform.position, Quaternion.identity);
        }
        else if ( cur_Time ==9000)
        {
            Instantiate(hinhThoi, transform.position, Quaternion.identity);
        }
        else if (cur_Time == 6000)
        {
            Instantiate(tamGiac, transform.position, Quaternion.identity);
        }
        else if (cur_Time == 3000)
        {
            Instantiate(Hcn, transform.position, Quaternion.identity);
        }
        else if (cur_Time == 0)
        {
            cur_Time = spawnTime;
        }
    }
}
