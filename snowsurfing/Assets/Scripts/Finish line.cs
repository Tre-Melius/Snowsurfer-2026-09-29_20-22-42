using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision)
   {
        int layerIndex = LayerMask.NameToLayer("Player");


        if (collision.gameObject.layer == layerIndex)
        {
            SceneManager.LoadScene(0);
        }
   }
}
