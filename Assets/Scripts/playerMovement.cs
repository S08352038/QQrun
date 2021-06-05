using UnityEngine;

//控制玩家移動
public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;   //Rigidbody剛體  //對應屬性面板中的rb（將Rigidbody拖入rb）
    public float forwardForce = 500f;   //前進的速度
    public float sidewaysForce = 100f;   //調整力度

    void FixedUpdate()   //固定速度  //FixedUpdate執行的間隔時間是相同的 物理運動適合用FixedUpdate而不是Update
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   //對rb剛體添加向前的力量（不斷增加力量）
        //可用Time.deltaTime來延遲某物件的transform的改變差距（時間增量）

        if (Input.GetKey("d"))   //Input.GetKey可獲取按下鍵盤的值
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   //向右的力量
            //ForceMode.VelocityChange：瞬間的加速度 但忽略其質量
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   //向左的力量
        }

        if(transform.position.x > 8)   //限制玩家移動範圍
        {
            transform.position = new Vector3(8, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -8)   //限制玩家移動範圍
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        }

        if (transform.position.z > 509)   //限制玩家移動範圍
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 509);
        }

    }
}
