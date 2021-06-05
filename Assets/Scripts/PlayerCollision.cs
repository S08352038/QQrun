using UnityEngine;
using UnityEngine.UI;

//控制玩家碰撞
public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;   //元件引用  //控制玩家前進的腳本Scripts（將要控制的元件playerMovement拖入movement）
    public Image GameOver;
    public Image WIN;

    private void OnCollisionEnter(Collision collision)   //當物體被碰撞就會觸發
    {
        if (collision.collider.tag == "Obstacle")   //如果撞到障礙物的標籤tag等於Obstacle時
        {
            movement.enabled = false;   //元件關閉  //控制元件：有效化Enable、無效化Disable 的指令
            GameOver.gameObject.SetActive(true);
        }

        if(collision.collider.tag == "WIN")
        {
            WIN.gameObject.SetActive(true);
        }
    }
}
