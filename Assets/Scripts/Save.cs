using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        oyunu_kaydet();
    }

    public void oyunu_kaydet()
    {
        PlayerPrefs.SetFloat("X", transform.position.x);
        PlayerPrefs.SetFloat("Y", transform.position.y);
        PlayerPrefs.SetFloat("Z", transform.position.z);
        PlayerPrefs.Save();
        Debug.Log("Oyun Kaydedildi ");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider coldr)
    {
        if (coldr.transform.tag == "Enemy")
        {
            float X = PlayerPrefs.GetFloat("X");
            float Y = PlayerPrefs.GetFloat("Y");
            float Z = PlayerPrefs.GetFloat("Z");

            transform.position = new Vector3(X,Y,Z);
            Debug.Log("Enemy Trigger sonrasi oyun geri yüklendi");
        }

        if (coldr.transform.tag == "levelChanger")
        {
            float X = PlayerPrefs.GetFloat("X");
            float Y = PlayerPrefs.GetFloat("Y");
            float Z = PlayerPrefs.GetFloat("Z");

            transform.position = new Vector3(X, Y, Z);
            Debug.Log("levelChanger Trigger sonrasi oyun geri yüklendi");
        }

    }
}
