using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
    public class red_Crystal : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;
            // Item.expert = true; 物品是专家模式及以上独有的，会改变物品的稀有度变成专家稀有度（彩虹渐变色）
            // Item.expertOnly = true; 饰品在专家难度以下不会生效，这不影响使用只影响装备效果，你在经典模式装备该饰品就会有一个红叉号并且属性无效
            // Item.master = true; 大师独有，改变稀有度为大师（金红渐变色）
            // Item.masterOnly = true; 仅大师难度以上生效

            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 1);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 10;
            //伤害增加 1是增加100%
            //player.GetDamage(DamageClass.Melee) += 1;

        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.Mushroom, 1);
            recipe.AddTile(TileID.WorkBenches);

            recipe.Register();
        }
    }
}