using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject detectGround;
    private bool isGrounded;
    private Animator animator;
    private bool canDoubleJump;

    public TextMeshProUGUI buttonText;

    public int scorePlayer;
    public float jumpIntensity = 8;
    public LayerMask groundMask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        detectGround = transform.Find("DetectGround").gameObject;
    }

    void Update()
    {
        Vector2 detectPosition = new Vector2(detectGround.transform.position.x, detectGround.transform.position.y);

        if (Input.GetButtonDown("Jump") && canDoubleJump && !isGrounded)
        {
            rb.AddForce(Vector2.up * jumpIntensity, ForceMode2D.Impulse);
            canDoubleJump = false;
            Debug.Log("double");
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpIntensity, ForceMode2D.Impulse);
            isGrounded = false;
            animator.SetBool("IsJumping", true);
        } else if (!Physics2D.OverlapCircle(detectPosition, 0.01f, groundMask))
        {
            
            isGrounded = false;
            animator.SetBool("IsJumping", true);
        } else if (Physics2D.OverlapCircle(detectPosition, 0.01f, groundMask) && !isGrounded)
        {
            canDoubleJump = true;
            isGrounded = true;
            animator.SetBool("IsJumping", false);
        }

        if (transform.position.y < -7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        buttonText.text = "Score: " + scorePlayer;
    }
    
    void FixedUpdate()
    {
        
    }

    public void SetScorePlayer()
    {
        scorePlayer += 100;
    }
}
