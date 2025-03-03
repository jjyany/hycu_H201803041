﻿using UnityEngine;

public class AmmoPack : MonoBehaviour, IItem
{
    //추가되는 탄알의 수량
    public int ammo = 30;

    public void Use(GameObject target)
    {
        var playerShooter = target.GetComponent<PlayerShooter>();

        if(playerShooter != null && playerShooter.gun != null)
        {
            playerShooter.gun.ammoRemain += ammo;
        }

        Destroy(gameObject);
    }
}