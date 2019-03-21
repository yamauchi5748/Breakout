using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public int boxNum = 0;
    public float nowTime;

    // Use this for initialization
    void Start () {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update () {
        nowTime += Time.deltaTime;
        if (boxNum <= 0) {
            GameOver(nowTime.ToString("F0") + "秒でクリアできた！");
        }
    }

    public void GameOver(string resultMessage) {
        DataSender.resultMessage = resultMessage;  //<=====受け取った引数をstatic変数へ格納
        SceneManager.LoadScene("Result");
    }
}