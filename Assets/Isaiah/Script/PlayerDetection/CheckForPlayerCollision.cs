using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForPlayerCollision : MonoBehaviour
{

    public GameObject player;
    public GameObject EnemyText;
    public GameObject fadeOut;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.GetComponent<RefinedMovement>().enabled = false;
            EnemyText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
            animator.SetBool("IsDead", true);
            
        }
    }

    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
