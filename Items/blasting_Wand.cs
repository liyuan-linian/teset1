using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using teset1.Projectiles;

namespace teset1.Items
{
    public class blasting_Wand : ModItem
    {
        public override void SetDefaults()
        {

            Item.damage = 15;
            Item.DamageType = DamageClass.Magic;

            Item.width = 20;
            Item.height = 20;
            //是否吟唱施法
            //Item.channel = true;

            Item.useTime = 60;
            Item.useAnimation = 60;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;//贴图不造成伤害

            Item.mana = 10;

            Item.shoot = ProjectileID.BallofFire;
            Item.shootSpeed = 2f;

        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.Wood, 1);
            //recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);

            recipe.Register();
        }
    }
}