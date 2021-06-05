using UnityEngine;
using UnityEngine.SceneManagement;   //遊戲場景管理


//控制菜單
public class MainMenu : MonoBehaviour
{
    public void PlayGame()   //遊戲開始
    {
        SceneManager.LoadScene(1);   //控制Scene的方法 跳至場景編號1
    }

    public void QuitGame()   //遊戲離開
    {
        Debug.Log("Quit!");   //在Console面板輸出訊息
        Application.Quit();   //關閉應用程式
    }

    public void Mainmenu()   //遊戲選單
    {
        SceneManager.LoadScene(0);   //控制Scene的方法 跳至場景編號0
    }

}
