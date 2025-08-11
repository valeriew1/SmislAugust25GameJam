using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    public enum GameState
    {
        MainMenu,
        RoomPlay,
        MiniGame,
        Paused,
        GameOver
    }


    private GameState currentState = GameState.MainMenu;
    //private GameState currentState = GameState.MainMenu;

    public delegate void OnStateChanged(GameState newState);
    public event OnStateChanged onStateChanged;

    public GameState CurrentState
    {
        get { return currentState; }
    }

    protected override void Awake()
    {
        base.Awake();
    }


    public void ChangeState(GameState newState)
    {
        if (currentState == newState)
        {
            return;
        }

        currentState = newState;

        onStateChanged?.Invoke(newState);

        switch (newState)
        {
            case GameState.MainMenu:
                Time.timeScale = 1f;
                Debug.Log("Главное меню");
                break;

            case GameState.RoomPlay:
                Time.timeScale = 1f;
                Debug.Log("Вы в комнате");
                break;

            case GameState.MiniGame:
                Time.timeScale = 1f;
                Debug.Log("Мини-игра началась");
                break;

            case GameState.Paused:
                Time.timeScale = 0f;
                Debug.Log("Игра на паузе");
                break;

            case GameState.GameOver:
                Time.timeScale = 0f;
                Debug.Log("Игра окончена");
                break;
        }
    }


    public void RoomPLayGame()
    {
        ChangeState(GameState.RoomPlay);
    }

    public void MiniPlayGame() 
    {
        ChangeState(GameState.MiniGame);
    }

    public void PauseGame()
    {
        if (currentState == GameState.RoomPlay || currentState == GameState.MiniGame)
            ChangeState(GameState.Paused);
    }

    public void ResumeRoomGame()
    {
        if (currentState == GameState.Paused)
            ChangeState(GameState.RoomPlay);
    }
    public void ResumeMiniGame()
    {
        if (currentState == GameState.Paused)
            ChangeState(GameState.MiniGame);
    }

    public void GameOver()
    {
        ChangeState(GameState.GameOver);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void RestartMiniLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ChangeState(GameState.MiniGame);
    }

    public void AutoNextState() 
    {
        if (currentState == GameState.MainMenu)
        { 
            ChangeState(GameState.RoomPlay); 
        }
        if (currentState == GameState.RoomPlay)
        { 
            ChangeState(GameState.MiniGame); 
        }
        if (currentState == GameState.MiniGame)
        { 
            ChangeState(GameState.RoomPlay); 
        }
        
    }

}












