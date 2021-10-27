using UnityEngine;

public class Detection : MonoBehaviour
{
    private Tower towerParent { get; set; } = null;
    private void Start()
    {
        towerParent = GetComponentInParent<Tower>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            towerParent.addEnemy(enemy);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            towerParent.removeEnemy(enemy);
        }
    }
}
