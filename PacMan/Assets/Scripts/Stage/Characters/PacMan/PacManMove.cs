using UnityEngine;
using System.Collections;

public class Pacman : MonoBehaviour
{
	bool rightMovement = false;
    bool leftMovement = false;
    bool forwardMovement = false;
    bool backMovement = false;
    public float speed = 5.0f;
    public Transform spawnPoint;
    public AudioClip death;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        AllWrong();

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            rightMovement = true;
            leftMovement = false;
            forwardMovement = false;
            backMovement = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            leftMovement = true;
            rightMovement = false;
            forwardMovement = false;
            backMovement = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            forwardMovement = true;
            rightMovement = false;
            leftMovement = false;
            backMovement = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            backMovement = true;
            rightMovement = false;
            forwardMovement = false;
            leftMovement = false;
        }
    }

    void AllWrong()
    {
        if (forwardMovement == true)
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (backMovement == true)
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (leftMovement == true)
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (rightMovement == true)
            transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
            source.PlayOneShot(death, 1f);
            gameObject.transform.position = spawnPoint.transform.position;
    }
}
