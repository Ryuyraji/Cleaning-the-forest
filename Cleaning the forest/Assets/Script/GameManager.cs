using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // 싱글톤 패턴을 사용하여 GameManager 인스턴스에 접근합니다.
    public Text scoreText; // 점수를 출력할 UI 텍스트
    private int score = 0; // 게임 점수
    private bool isGameover = false; // 게임 오버 상태 여부

    private void Awake()
    {
        // GameManager의 인스턴스를 설정합니다.
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "Score: " + score;
        }
    }
}
