using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace teset1.Items
{
    public class Null_Magic_Mantle : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 1);

        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance += 0.05f;
            player.runAcceleration += 0.02f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);

            recipe.Register();
        }
    }
}