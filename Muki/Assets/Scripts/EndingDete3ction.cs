using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingDete3ction : MonoBehaviour
{

    PointHolder point;


    // Start is called before the first frame update
    void Start()
    {

        point = GetComponent<PointHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (point.Points == 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

     
    }

}
