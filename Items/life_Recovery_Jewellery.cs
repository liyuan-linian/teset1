using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
    public class life_Recovery_Jewellery : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 1);

        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //生命恢复计算 = lifeRegen / 120 * 60 = 0.5 * liferegan per second 
            player.lifeRegen += 1;
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