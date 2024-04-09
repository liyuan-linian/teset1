using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
    public class short_Sword : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 1;
            Item.DamageType = DamageClass.Melee;

            Item.width = 30;
            Item.height = 30;//贴图的大小

            Item.useTime = 10;
            Item.useAnimation = 10;

            Item.useStyle = ItemUseStyleID.Thrust;

            Item.useTurn = false;
            Item.knockBack = 1;

            Item.value = Item.sellPrice(0, 0, 0, 1);


            Item.rare = ItemRarityID.White;

            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();//括号里的参数可以表示一次合成生成多少个
                                           //recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddRecipeGroup("Wood", 1);
            recipe.AddTile(TileID.WorkBenches);

            recipe.Register();
        }
    }
}