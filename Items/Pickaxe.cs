using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
    public class Pickaxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Melee;

            Item.useStyle = ItemUseStyleID.Swing;

            Item.width = 25;
            Item.height = 25;

            Item.useAnimation = 45;
            Item.useTime = 25;

            Item.pick = 40;
            //击退力
            Item.knockBack = 6;

            Item.value = Item.sellPrice(0, 0, 0, 1);

            //稀有度
            Item.rare = ItemRarityID.White;

            Item.useTurn = true;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();//括号里的参数可以表示一次合成生成多少个
            //recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddRecipeGroup("Wood", 1);

            recipe.AddTile(TileID.WorkBenches);

            //添加环境
            //recipe.AddCondition(Condition.NearHoney);

            recipe.Register();
        }
    }
}