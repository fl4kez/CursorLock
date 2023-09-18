using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace CursorLock
{
    public class LockPlayer : ModPlayer
    {
        
        
        public static int padLeft, padTop, padRight, padBottom;
        public static bool locked;
        public override void PostUpdate()
        {
            if (!Main.dedServ)
            {
                if (locked)
                {
                    MouseState state = Mouse.GetState();
                    Vector2 mosPos = new Vector2(state.X, state.Y);
                    mosPos.X = Math.Clamp(mosPos.X, 0 + padLeft, CursorLock.res.X - padRight);
                    mosPos.Y = Math.Clamp(mosPos.Y, 0 + padTop, CursorLock.res.Y - padBottom);
                    Mouse.SetPosition((int)mosPos.X, (int)mosPos.Y);
                }
            }
            //Mouse.SetPosition((int)mousePos.X, (int)mousePos.Y);
            //Mouse.SetPosition(1880, 1040);
            //NEW TEST
            //Main.NewText($"{res.X}");
            //Main.NewText($"{Main.MouseScreen} {mousePos} {{XL:{1 + xOffset} XR:{res.X - 1 - xOffset}}}");
        }
        /*04.11.2022 20:27
          public override void PostUpdate()
        {
            float zoom = Main.GameZoomTarget;

            Vector2 mousePos = Main.MouseScreen;
            int xOffset = (int)((res.X - (res.X / zoom)) / 2);
            int yOffset = (int)((res.Y - (res.Y / zoom)) / 2);

            float middleX = ((0 + xOffset) + (res.X - xOffset)) / 2;
            float middleY = ((0 + yOffset) + (res.Y - yOffset)) / 2;
            mousePos.X = Math.Clamp(mousePos.X, 0+xOffset, res.X-xOffset);
            mousePos.Y = Math.Clamp(mousePos.Y, 0+yOffset, res.Y-yOffset);
            if (mousePos.X < middleX)
                xOffset = -xOffset;
            if (mousePos.Y < middleY)
                yOffset = -yOffset;
            Mouse.SetPosition((int)mousePos.X+xOffset, (int)mousePos.Y+yOffset);
            //Mouse.SetPosition(1880, 1040);
            //NEW TEST
            Main.NewText($"{res.X}");
            Main.NewText($"{Main.MouseScreen} {mousePos} {{XL:{1 + xOffset} XR:{res.X - 1 - xOffset}}}");
        }
         
         */
    }
}
