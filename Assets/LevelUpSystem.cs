using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class LevelUpSystem : ComponentSystem
{
    protected override void OnUpdate() {
        Entities.ForEach((ref LevelUpComponent levelUpComponent) =>
        {
            levelUpComponent.level += 1f * Time.DeltaTime;
            Debug.Log(levelUpComponent.level);

        });
    
    }


}
