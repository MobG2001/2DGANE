using UnityEngine;

/// <summary>
/// 傷害系統
/// </summary>
namespace Mob
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("碰撞:" + collision.gameObject);

            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }
    }

}
