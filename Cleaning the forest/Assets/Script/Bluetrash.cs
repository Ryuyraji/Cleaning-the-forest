using UnityEngine;

public class Bluetrash : MonoBehaviour
{
    public int scoreValue = 10;  // �����⿡ �ο��� ����
    public AudioClip dingSound;  // �� �Ҹ� Ŭ��
    private AudioSource audioSource;

    private void Awake()
    {
        // AudioSource ������Ʈ�� �����ɴϴ�.
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue"))
        {
            // �浹�� ������Ʈ�� �Ķ��� ������Ʈ�� ��쿡�� ������ ������ŵ�ϴ�.
            GameManager.Instance.AddScore(scoreValue);

            // �浹�� ������ ������Ʈ�� �����մϴ�.
            Destroy(gameObject);

            // �� �Ҹ��� ����մϴ�.
            PlayDingSound();
        }
    }

    private void PlayDingSound()
    {
        // AudioSource�� ���� �� �Ҹ��� ����մϴ�.
        audioSource.PlayOneShot(dingSound);
    }
}
