using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int pickupsCollected;

    public Text score;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pickupsCollected = 0;
        SetScoreText();


    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(force * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("token"))
        {
            other.gameObject.SetActive(false);
            pickupsCollected++;
            SetScoreText();


        }

    }

    void SetScoreText()
    {
        score.text = "Score: " + pickupsCollected.ToString() + " / 26";
    }

}
