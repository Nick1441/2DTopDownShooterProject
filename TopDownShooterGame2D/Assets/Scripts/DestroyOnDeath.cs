using UnityEngine;
public class DestroyOnDeath : MonoBehaviour
{
    //Setting the death Boolean to True when an ememy is dead. Then kills them, playing the animation.
    public void Die()
    {
        GetComponent<Animator>().SetBool("isDead", true);
        Destroy(gameObject);
    }
}
