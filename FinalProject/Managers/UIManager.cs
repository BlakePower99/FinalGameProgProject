﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Color = Microsoft.Xna.Framework.Color;

namespace FinalProject.Managers
{
    public class UIManager
    {
        private static SpriteFont font = Shared.Content.Load<SpriteFont>("fonts/MyFont");

        public static void Draw(Player player)
        {
            Color color = player.Reloading ? Color.Red : Color.Black;

            Shared.SpriteBatch.DrawString(font, $"{player.Ammo}", Vector2.Zero, color);

            Shared.SpriteBatch.DrawString(font, $"Score: {Shared.Score}", new Vector2(0, 845), Color.Black);
        }
    }
}
