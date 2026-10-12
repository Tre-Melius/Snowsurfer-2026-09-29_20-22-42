using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
     [SerializeField] float reloadTime = 1f;
     [SerializeField] ParticleSystem finishParticles;
   void OnTriggerEnter2D(Collider2D collision)
   {
        int layerIndex = LayerMask.NameToLayer("Player");


        if (collision.gameObject.layer == layerIndex)
        {
            finishParticles.Play();
            Invoke("ReloadScene", reloadTime);
        }
   }

   void ReloadScene()
   {
        SceneManager.LoadScene(0);
   }
}
