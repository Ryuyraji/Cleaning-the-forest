using UnityEngine;

public class Yellowtrash : MonoBehaviour
{
    public int scoreValue = 10;  // �����⿡ �ο��� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Yellow"))
        {
            // �浹�� ������Ʈ�� ����� ������Ʈ�� ��쿡�� ������ ������ŵ�ϴ�.
            GameManager.Instance.AddScore(scoreValue);

            // �浹�� ������ ������Ʈ�� �����մϴ�.
            Destroy(gameObject);
        }
    }
}
