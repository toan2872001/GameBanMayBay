using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class  GameController : MonoBehaviour
{

    int score;
    public TextMeshProUGUI killCounting;
    public GameObject hinhVuong;
    public GameObject hinhThoi;
    public GameObject tamGiac;
    public GameObject Hcn;
    public int Score { get => score; set => score = value; }
    public void IncreScore()
    {
        score++;
    }

    // Start is called before the first frame update
    public void Start()
    {
        
        StartCoroutine(CreateEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        killCounting.text = score.ToString();
    }
    IEnumerator CreateEnemy()
    {
        int t = 0;
        while (t <= 3)
        {
            CreteHinhVuong();
            yield return new WaitForSeconds(20);
            CreteHinhThoi();
            yield return new WaitForSeconds(20);
            CreteTamGiac();
            yield return new WaitForSeconds(20);
            CreteHcn();
            yield return new WaitForSeconds(20);
        }
    }
    
    public void CreteHinhVuong()
    {
        Instantiate(hinhVuong, transform.position, Quaternion.identity);
    }
    public void CreteHinhThoi()
    {
        Instantiate(hinhThoi, transform.position, Quaternion.identity);
    }
    public void CreteTamGiac()
    {
        Instantiate(tamGiac, transform.position, Quaternion.identity);
    }
    public void CreteHcn()
    {
        Instantiate(Hcn, transform.position, Quaternion.identity);
    }
}
