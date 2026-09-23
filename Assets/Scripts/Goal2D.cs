using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Goal2D : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    private bool completed;

    private void Awake()
    {
        winCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (completed || other.attachedRigidbody == null)
            return;

        PlayerController2D player = other.attachedRigidbody.GetComponent<PlayerController2D>();
        if (player == null)
            return;

        completed = true;
        winCanvas.SetActive(true);
        player.CompleteLevel();
    }
}
