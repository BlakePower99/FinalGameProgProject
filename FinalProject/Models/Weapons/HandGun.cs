﻿using FinalProject.Managers;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.Weapons
{
    public class HandGun : Weapon
    {
        private SoundEffect pistolShot = Shared.Content.Load<SoundEffect>("sounds/pistol_shot");
        private SoundEffect pistolReload = Shared.Content.Load<SoundEffect>("sounds/pistol_reload");
        public HandGun()
        {
            cooldown = 0.7f;
            maxAmmo = 12;
            Ammo = maxAmmo;
            reloadTime = 1.2f;
            GunShot = pistolShot;
            ReloadSound = pistolReload;
        }

        protected override void CreateProjectiles(Player player)
        {
            ProjectileData projectileData = new()
            {
                Position = player.Position,
                Rotation = player.Rotation,
                Lifespan = 2f,
                Speed = 400
            };

            ProjectileManager.AddProjectile(projectileData);
        }
    }
}