using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviorScript : MonoBehaviour
{
    public float keyinput;
    public AudioSource touchssound;
    public float verticalInput;
   // public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        touchssound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        // Specify the key for jump (Space Using for jump)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 7, ForceMode.VelocityChange);
        }

        // Left Right movement with keyboard
        keyinput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().linearVelocity = new Vector3(keyinput,GetComponent<Rigidbody>().linearVelocity.y, 0);

        // verticalInput = Input.GetAxis("Vertical");

        // Move in both directions Up Down Right Left With keyboard
        // GetComponent<Rigidbody>().linearVelocity = new Vector3(keyinput, verticalInput, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("candy"))
            touchssound.Play();
    }
}
