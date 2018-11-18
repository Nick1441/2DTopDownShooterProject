using UnityEngine;
public class DestroyOnDeath : MonoBehaviour
{

    public void Die()
    {
        Destroy(gameObject);
    }
}
