using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace teset1.Items
{
    public class cloth_Armor : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;

            Item.defense = 4;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 0, 0, 1);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);

            recipe.Register();
        }
    }
}