using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager 클래스의 싱글톤 인스턴스를 저장하는 정적 변수
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // Instance가 아직 초기화되지 않았다면 현재 객체를 싱글톤 인스턴스로 설정
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int score;
    public int level;
    public bool isGameOver;

    public void StartGame()
    {
        score = 0;
        level = 1;
        isGameOver = false;
        // 게임 시작 로직을 추가
    }

    public void GameOver()
    {
        isGameOver = true;
        // 게임 오버 로직을 추가
    }
}
