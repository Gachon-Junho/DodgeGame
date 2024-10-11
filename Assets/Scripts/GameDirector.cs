using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoSingleton<GameDirector>
{
    [SerializeField]
    private ObstacleGenerator obstacleGenerator;

    [SerializeField] 
    private GameObject gameOverOverlay;

    [SerializeField] 
    private Player player;

    public void GameOver()
    {
        obstacleGenerator.Stop();
        gameOverOverlay.SetActive(true);
        player.Movable = false;
    }

    public void Restart() => SceneManager.LoadScene("Scenes/SampleScene");
}
