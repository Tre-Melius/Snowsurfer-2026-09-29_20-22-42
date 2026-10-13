using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    [SerializeField] PowerupSO powerup;
    NewMonoBehaviourScript player;

    void Start()
    {
        player = FindAnyObjectByType<NewMonoBehaviourScript>();
    }

    void OnTriggerEnter2d(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");


        if (collision.gameObject.layer == layerIndex)
        {
            player.ActivatePowerup(powerup);
        }
    }
}
