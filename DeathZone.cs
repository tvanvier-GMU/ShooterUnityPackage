using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The idea of this script is that it will be used on a trigger area, to send you back to the starting position in your level.
//it's a penalty that will waste your precious time!
[RequireComponent(typeof(Collider))]
public class DeathZone : MonoBehaviour
{
    public Transform respawnPoint;
    public string playerTag = "Player";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
