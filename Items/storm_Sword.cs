using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
    public class storm_Sword : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 20;
            Item.DamageType = DamageClass.Melee;

            Item.width = 30;
            Item.height = 30;

            Item.useTime = 40;
            Item.useAnimation = 40;

            Item.useStyle = ItemUseStyleID.Thrust;

            Item.value = Item.sellPrice(0, 0, 0, 10);

            Item.useTurn = true;

            Item.knockBack = 10;
            Item.rare = ItemRarityID.Green;


            Item.UseSound = SoundID.Item4;

            Item.autoReuse = true;
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