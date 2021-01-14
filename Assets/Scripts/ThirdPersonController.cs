using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdPersonController : MonoBehaviour
{
    public float speed=20f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
    }
    // Mouse İle hareket Ettirme 
    public float horizontalSpeed = 3.0F;
    public float verticalSpeed = 3.0F;
    void Update()
    {

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
        // Karakteri W,a,s,d ile hareket ettirme
        
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.Escape))
            {
            SceneManager.LoadScene("MainMenu");
            }

    }

    void OnTriggerEnter(Collider coldr)
    {
        if (coldr.transform.tag == "levelChanger")
        {
            Debug.Log("Triggera Girildi");
        }

        
    }
     void OnTriggerExit(Collider coldr)
    {
        if (coldr.transform.tag == "levelChanger")
        {
            Debug.Log("Triggerdan Cikildi !");
        }
    }
         
}
