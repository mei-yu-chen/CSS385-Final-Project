using UnityEngine;

public class Gem : MonoBehaviour, Item
{
    public AudioClip collectSound;

    public void Collect()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);

        GameManager gm = GameObject.FindFirstObjectByType<GameManager>();
        if (gm != null)
        {
            gm.itemCount++;
            Debug.Log("Item collected! itemCount = " + gm.itemCount);
        }
        else
        {
            Debug.LogError("GameManager not found!");
        }

        Destroy(gameObject);
    }
}
