using UnityEngine;

//控制相機
public class FloowPlayer : MonoBehaviour
{
    public Transform Player;   //控制大小、偏移、縮放（將要控制的對象Player拖入Player）
    public Vector3 offset;   //位置變量（xyw、差值）

    void Update()
    {
        transform.position = Player.position + offset;   //把玩家的位置傳給相機（用+offset彌補距離）  //相機位置 = 玩家位置
    }
}
