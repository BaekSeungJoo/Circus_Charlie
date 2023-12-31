using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class Stage2_Wait_Gameover : MonoBehaviour
{
    public GameData gameData;
    public Text Stage2_Wait_Text;

    // Start is called before the first frame update
    void Start()
    {
        int life_ = gameData.life;

        // 게임이 오버 되었을 때
        if (life_ == 0)
        {
            Stage2_Wait_Text.text = string.Format("GameOver");
        }

        // 게임이 오버되지 않았을 때
        else
        {
            Stage2_Wait_Text.text = string.Format("Stage2 ...");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
