using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementController : MonoBehaviour
{
    public float Speed = 10.0f;
    Rigidbody2D playerRigidbody;
    Animator playerAnimator;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Fixed count of calls per second.
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);

        // Normalized for length one in each directions
        playerRigidbody.velocity = direction.normalized * Speed;

        playerAnimator.SetBool("IsFlyingLeft", horizontal < 0);
        playerAnimator.SetBool("IsFlyingRight", horizontal > 0);
        playerAnimator.SetBool("IsFlyingUp", vertical > 0);
    }

    // When Player dies
    private void OnDisable()
    {
        // Load main scene (restart)
        SceneManager.LoadScene(0);
    }
}
