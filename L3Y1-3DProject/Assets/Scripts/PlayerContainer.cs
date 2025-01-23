using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContainer : MonoBehaviour
{
    public Vector3 lastPos;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

   void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.CompareTag("KillTrigger"))
    {
        transform.position = lastPos;
    }
    if (other.gameObject.CompareTag("Checkpoint"))
    {
        lastPos = transform.position;
    }
    if (other.gameObject.CompareTag("BackWarp"))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
   }
}
