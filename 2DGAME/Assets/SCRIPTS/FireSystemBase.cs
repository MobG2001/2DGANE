using UnityEngine;

namespace Mob
{
    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullets;
        [SerializeField, Header("子彈生成點")]
        private Transform pointspawn;

        protected void SpawnBullet()
        {
            Instantiate(prefabBullets, pointspawn.position, pointspawn.rotation);
        }
    }
}

