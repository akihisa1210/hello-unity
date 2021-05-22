using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int boxCount;
    public float now;

    // Start is called before the first frame update
    void Start()
    {
        now = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        now += Time.deltaTime;
        if (boxCount <= 0) {
            GameOver(now.ToString("F0") + "秒でクリア！");
        }
    }

    public void GameOver(string resultMessage)
    {
        DataSender.resultMessage = resultMessage;
        SceneManager.LoadScene("Result");
    }
}
