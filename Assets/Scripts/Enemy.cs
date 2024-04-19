using UnityEngine;

public class Enemy : MonoBehaviour {
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody enemyRb;
    [SerializeField] private GameObject player;
    private const string targetName = "target";

    private void Start() {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find(targetName);
    }

    private void Update() {
        if (player != null) {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        } else {
            player = GameObject.Find(targetName);
        }
    }

}
