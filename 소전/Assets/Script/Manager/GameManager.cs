using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    //항상 접근 가능한 변수
    public static GameManager instance;
    public UITimer timerUI;
    public UIScore scoreUI;
    public UIEndGame endGameUI;
    //2. 제한시간 내에 최대한 파괴
    private void Start()
    {
        Time.timeScale = 1.0f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
    //현재 시간
    public float timer;
    //플레이 타임
    public float playTime;

    //파괴한 수
    public int score;
    
    void Awake() {
        instance = this;
        /*if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);*/
    }

    void Update() { //필수
        //TODO :: 타이머가 실행되요.
        TimeUpdate();
    }

    void TimeUpdate() { //필수
        //TODO :: 타이머가 변화 << 변화 값? 프레임을 보간하기 위해 사용한 상수를 더해보자.
        timer += Time.deltaTime;
        timerUI.UpdateTime((int)timer);
        //TODO :: 타이머와 플레이 타임을 비교하여 게임 끝냄
        if (timer >= playTime) {
            EndGame();
        }
    }

    void EndGame() {
        //TODO :: 게임을 끝낸다.
        
        Time.timeScale = 0.0f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        endGameUI.Open(score);
    }

    public void AddScore() { //필수
        //TODO :: 점수를 올려요.
        ++score;
        scoreUI.UpdateScore(score);
    }
}
