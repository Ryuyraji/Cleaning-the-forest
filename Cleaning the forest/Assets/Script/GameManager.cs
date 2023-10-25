using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // �̱��� ������ ����Ͽ� GameManager �ν��Ͻ��� �����մϴ�.
    public Text scoreText; // ������ ����� UI �ؽ�Ʈ
    private int score = 0; // ���� ����
    private bool isGameover = false; // ���� ���� ���� ����

    private void Awake()
    {
        // GameManager�� �ν��Ͻ��� �����մϴ�.
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("���� �ΰ� �̻��� ���� �Ŵ����� �����մϴ�!");
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
