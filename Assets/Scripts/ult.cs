using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ult : MonoBehaviour
{
    //act 90
public Transform cannonPivot;   
    public GameObject bulletPrefab;  
    public float rotationSpeed = 50f;  
    public float bulletSpeed = 10f;  
    public float bulletLifetime = 5f; 

    private void Update()
    {
        cannonPivot.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            GameObject bullet = Instantiate(bulletPrefab, cannonPivot.position, cannonPivot.rotation);
            
            bullet.GetComponent<Rigidbody>().velocity = cannonPivot.forward * bulletSpeed;
            
            Destroy(bullet, bulletLifetime);
        }
    }

//act91

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayRandomSoundEffect();

            ChangeBackgroundColor();
        }
    }

    private void PlayRandomSoundEffect()
    {
        int randomIndex = Random.Range(0, soundEffects.Length);

        audioSource.PlayOneShot(soundEffects[randomIndex]);
    }

    private void ChangeBackgroundColor()
    {
        int randomIndex = Random.Range(0, colors.Length);

        mainCamera.backgroundColor = colors[randomIndex];
    }

//act 92

private void Start()
    {
        SpawnEnemy();
        UpdateWaveText();
    }

    private void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            currentWave++;
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity);
    }

    //act93

    public void NextAnimation()
    {
        int currentAnimation = animator.GetInteger("AnimationIndex");
        currentAnimation++;
        animator.SetInteger("AnimationIndex", currentAnimation);
    }

    public void PreviousAnimation()
    {
        int currentAnimation = animator.GetInteger("AnimationIndex");
        currentAnimation--;
        animator.SetInteger("AnimationIndex", currentAnimation);
    }

    public void RandomAnimation()
    {
        int totalAnimations = animator.GetParameter(0).nameHash;}

        //act94

        private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(other.gameObject); 

            if (coinCount >= totalCoins)
            {
                winPanel.SetActive(true);
            }
        }
    }

    //act95

     

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            optionsPanel.SetActive(true);
            onPlatform = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            optionsPanel.SetActive(false);
            onPlatform = false;
        }
    }

    public void SetPlayerColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
    //act96

private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lives--;

            livesText.text = "Lives: " + lives;

            transform.position = Vector3.zero;

            if (lives <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }

    //act99
    void Start()
{
    rb = GetComponent<Rigidbody>();
}
void FixedUpdate()
{
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
    rb.velocity = movement * moveSpeed;
}
void Start()
{
    groundSize = GetComponent<BoxCollider>().size.x;
}
void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
        Vector3 newPosition = transform.position;
        if (other.transform.position.x > transform.position.x)
        {
            newPosition.x += groundSize;
        }
        else if (other.transform.position.x < transform.position.x)
        {
            newPosition.x -= groundSize;
        }

        Instantiate(groundPrefab, newPosition, Quaternion.identity);
    }
}

}
