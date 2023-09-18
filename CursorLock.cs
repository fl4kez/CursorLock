using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CursorLock
{
	public class CursorLock : Mod
	{
        public static Point res;
        public override void Load()
        {
            if(!Main.dedServ)
            { 
                res = new Point(0, 0);
                Main.OnResolutionChanged += SetLimits;
                res.X = Main.screenTarget.Width;//Main.ScreenSize.X;
                res.Y = Main.screenTarget.Height;//Main.ScreenSize.Y;
            }

        }
        public void SetLimits(Vector2 limit)
        {
            Main.NewText("Cursor Lock:Changed Limits");
            res.X = Main.ScreenSize.X;
            res.Y = Main.ScreenSize.Y;
        }
    }
}