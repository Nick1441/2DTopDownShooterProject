using UnityEngine;
public class DestroyOnDeath : MonoBehaviour
{

    public void Die()
    {
        GetComponent<Animator>().SetBool("isDead", true);
        Destroy(gameObject);
    }
}
