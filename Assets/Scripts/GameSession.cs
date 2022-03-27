using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI _livesT;
    [SerializeField] TextMeshProUGUI _scoreT;
    PlayerController _player;

    void Awake() 
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start() 
    {
        _livesT.text = playerLives.ToString(); 
        _scoreT.text = score.ToString(); 
    }

    public void ProcessPlayerDeath()
    {
        if(playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }
    }
    public void TakeCoin(int pointsToAdd)
    {
        score += pointsToAdd;
        _scoreT.text = score.ToString();
    }
    void ResetGameSession()
    {
        //FindObjectOfType<ScenePersist>().ScenePersistDeath();
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    void TakeLife()
    {
        playerLives--;
        score = 0;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        _livesT.text = playerLives.ToString();   

    }



}
