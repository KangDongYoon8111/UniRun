using UnityEngine;

// PlayerController�� �÷��̾� ĳ���ͷμ�
// Player ���� ������Ʈ�� ������
public class PlayerController : MonoBehaviour
{
    // ��� �� ����� ����� Ŭ��
    public AudioClip deathClip;
    // ���� ��
    public float jumpForce = 700f;

    // ���� ���� Ƚ��
    private int jumpCount = 0;
    // �ٴڿ� ��Ҵ��� ��Ÿ��
    private bool isGrounded = false;
    // ��� ����
    private bool isDead = false;

    // ����� ������ٵ� ������Ʈ
    private Rigidbody2D playerRigidbody;
    // ����� �ִϸ����� ������Ʈ
    private Animator animator;
    // ����� ����� �ҽ� ������Ʈ
    private AudioSource playerAudio;

    void Start()
    {
        // �ʱ�ȭ
        // ���� ������Ʈ�κ��� ����� ������Ʈ���� ������ �Ҵ�
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // ����� �Է��� �����ϰ� �����ϴ� ó��
    }

    private void Die()
    {
        // ��� ó��
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ٴڿ� ������� �����ϴ� ó��
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // �ٴڿ��� ������� �����ϴ� ó��
    }
}
