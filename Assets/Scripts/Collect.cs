using UnityEngine;
using UnityEngine.UI;

//玩家碰到小熊軟糖 金幣消失
public class Collect : MonoBehaviour
{
    public int playerScore;   //記錄玩家分數
    public Text ShowplayerScore;
    void Start()
    {
        playerScore = 0;
    }
    void Update()
    {
        ShowplayerScore.text = playerScore.ToString();  //顯示玩家分數
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (other.gameObject.tag == "R")   //如果碰到小熊軟糖 分數增加
        {
            playerScore += 50;   //+= 對既有數值作加減
        }
        if (other.gameObject.tag == "O")
        {
            playerScore += 20;
        }
        if (other.gameObject.tag == "Y")
        {
            playerScore += 10;
        }
        if (other.gameObject.tag == "G")
        {
            playerScore += 10;
        }
        if (other.gameObject.tag == "B")
        {
            playerScore += 20;
        }
        if (other.gameObject.tag == "P")
        {
            playerScore += 10;
        }
    }
}





