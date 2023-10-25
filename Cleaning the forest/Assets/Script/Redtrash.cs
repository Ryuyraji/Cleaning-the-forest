using UnityEngine;

public class Redtrash : MonoBehaviour
{
    public int scoreValue = 10;  // 쓰레기에 부여할 점수

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            // 충돌한 오브젝트가 노란색 오브젝트인 경우에만 점수를 증가시킵니다.
            GameManager.Instance.AddScore(scoreValue);

            // 충돌한 쓰레기 오브젝트를 삭제합니다.
            Destroy(gameObject);
        }
    }
}