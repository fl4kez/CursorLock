using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace CursorLock
{
    public class CursorLockConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;


        [Label("Use lock")]
        [DefaultValue(true)]
        public bool locked;



        [Label("Padding left")]
        [Range(0, 50)]
        [DefaultValue(5)]
        public int padLeft;
        [Label("Padding top")]
        [Range(0, 50)]
        [DefaultValue(5)]
        public int padTop;
        [Label("Padding right")]
        [Range(0, 50)]
        [DefaultValue(5)]
        public int padRight;
        [Label("Padding bottom")]
        [Range(0, 50)]
        [DefaultValue(5)]
        public int padBottom;

        public override void OnChanged()
        {
            LockPlayer.padLeft = padLeft;
            LockPlayer.padTop = padTop;
            LockPlayer.padRight = padRight;
            LockPlayer.padBottom = padBottom;
            LockPlayer.locked = locked;
        }
        public override void OnLoaded()
        {
            LockPlayer.padLeft = padLeft;
            LockPlayer.padTop = padTop;
            LockPlayer.padRight = padRight;
            LockPlayer.padBottom = padBottom;
            LockPlayer.locked = locked;

        }
    }
}
