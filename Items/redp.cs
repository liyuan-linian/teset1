using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
	public class redp : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.teset1.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 500;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.shoot = ProjectileID.Bubble;
			Item.shootSpeed = 7f;
			Item.UseSound = SoundID.Item10;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddIngredient(ModContent.ItemType<sowrd>(), 1);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.AddTile(TileID.WorkBenches);

			//添加环境
			//recipe.AddCondition(Condition.NearHoney);

			recipe.Register();
		}

	}
}
