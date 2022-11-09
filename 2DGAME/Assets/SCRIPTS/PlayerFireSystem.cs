using UnityEngine;

namespace Mob
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}

