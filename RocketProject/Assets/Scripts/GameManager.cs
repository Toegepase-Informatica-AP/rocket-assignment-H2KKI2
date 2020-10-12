using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public GameObject FinishCanvas;
    private Health healthPlayer;
    public enum GameStates { PLAYING, GAME_OVER, FINISH}
    public GameStates gameState = GameStates.PLAYING;
    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameStates.PLAYING:
                //Time.timeScale = 1;
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.GAME_OVER;
                    //Time.timeScale = 0;
                    if (mainCanvas != null)
                    {
                        mainCanvas.SetActive(false);
                    }    
                    gameOverCanvas.SetActive(true);
                }
                break;
            case GameStates.FINISH:
                if (mainCanvas != null)
                {
                    mainCanvas.SetActive(false);
                }
                /*Time.timeScale = 0;*/
                FinishCanvas.SetActive(true);
                break;
        }
    }

}
