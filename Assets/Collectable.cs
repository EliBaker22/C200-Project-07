using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 2f;

    [SerializeField] AudioSource audioSource;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }
}
