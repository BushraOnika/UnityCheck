using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {    // if collide with candi or platform then show hello
         // Debug.Log("Hello");
        if (collision.gameObject.CompareTag("candy")) {
            // Debug.Log("Candy");
            SceneManager.LoadScene(1);
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            //Debug.Log("Game Over");
            SceneManager.LoadScene(0);
        }
    }
}
