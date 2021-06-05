using UnityEngine;

//控制金幣旋轉
public class Coin : MonoBehaviour
{
    public int speed;   //金幣旋轉速度

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);   //物件轉動
    }
}
