using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerThings : MonoBehaviour
{
    public GameOverScript GameOver;
    public int health = 3;
    public int Maxhealth = 5;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        health = Maxhealth;
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
        }
    }





    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
