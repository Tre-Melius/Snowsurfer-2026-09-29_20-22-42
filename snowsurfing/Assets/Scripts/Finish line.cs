using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
   void OnTriggerEnter2D(Collider2D collision)
   {
        int layerIndex = LayerMask.NameToLayer("Player");


        if (collision.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", reloadTime);
        }
   }

   void ReloadScene()
   {
        SceneManager.LoadScene(0);
   }
}
