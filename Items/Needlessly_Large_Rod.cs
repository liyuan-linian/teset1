using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
    public class Needlessly_Large_Rod : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(0, 0, 0, 1);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Magic) += 0.15f;
            player.manaCost += 0.1f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            //recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);

            recipe.Register();
        }

    }
}