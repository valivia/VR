using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneOnTrigger : MonoBehaviour
{
    public string target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lever")
        {
            SceneManager.LoadScene(target);
            Debug.Log("deez nuts");
        }
    }
}
