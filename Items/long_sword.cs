using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace teset1.Items
{
	public class long_sword : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.teset1.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 5;
			Item.DamageType = DamageClass.Melee;
			// 决定了这个武器的伤害类型
			// Default 代表无属性（也就是不吃任何加成）
			// Generic 代表全属性（也就是全部加成都吃）所谓1.3的allDamage就是它了
			// MagicSummonHybrid 代表什么我不知道，但是可以同时吃到魔法和召唤加成
			// MeleeNoSpeed 代表近战，但是不吃攻速加成
			// Melee 代表近战
			// Ranged 代表远程
			// Magic 代表马猴烧酒，不，魔法
			// Summon 代表召唤
			// SummonMeleeSpeed 代表额......看看鞭子吧，可以吃到近战和召唤加成
			// Throwing 代表投掷（没错虽然1.4没了投掷武器，全给远程了，但是这个伤害类型还在！）

			Item.width = 20;
			Item.height = 20;//贴图的大小

			//使用速度和动画时间 60帧 time = 30 / 60 一般情况下保持一致 只有一次动画效果触发多次会不一致
			Item.useTime = 30;
			Item.useAnimation = 30;

			Item.useStyle = ItemUseStyleID.Swing;
			//// 0 或 None 代表......字面意思，就是啥都没有！你写了之后甚至无法使用！
			// 1 或 Swing 代表挥动，也就是剑类武器！
			// 2 或 EatFood 代表像食物一样，拥有物品，手持，放在盘子上三帧的贴图，具体可见exmod里头的🥧（派）https://github.com/Cyrillya/Example-Mod-Zh-Project/blob/master/Content/Items/Consumables/ExampleFoodItem.cs
			// 3 或 Thrust 代表像1.3的同志短剑一样刺x 出去（也就是朝左或右刺出）（如果你想要写全方位刺出的剑，那你还是得看exmod）
			// 4 或 HoldUp 唔，这个一般不是用在武器上的，想象一下生命水晶使用的时候的动作
			// 5 或 Shoot 手持，枪、弓、法杖类武器的动作，用途最广
			// 6 或 DrinkLong 代表直接猛喝，感兴趣可以自己看看，挺好玩的（
			// 7 或 DrinkOld 代表1.3的喝药水动作
			// 8 或 GolfPlay 代表高尔夫球杆的动作
			// 9 或 DrinkLiquid 代表1.4的喝药水动作，相比1.3的来说，这个动作的手臂更加流畅，持握位置会在瓶口
			// 10 或 HiddenAnimation 代表使用时无动画
			// 11 或 MowTheLawn 代表割草机的动作，神奇，这玩意还有单独的动作
			// 12 或 Guitar 代表常春藤、雨之歌等物品的动作，对这玩意也是单独的动作（爱抚剑ing
			// 13 或 Rapier 代表标尺、星光等武器的动作
			// 14 或 RaiseLamp 代表夜光的动作，好吧这也单独写一个动作的吗？话说这玩意翻译过来叫吊灯......夜光大吊灯（bushi

			//表示使用时是否可以转身
			Item.useTurn = true;

			//击退力
			Item.knockBack = 6;

			Item.value = Item.sellPrice(0, 0, 0, 1);

			//稀有度
			Item.rare = ItemRarityID.White;
			/*
						Item.shoot = ProjectileID.Bubble;
						Item.shootSpeed = 7f;
			*/
			Item.UseSound = SoundID.Item10;

			//鼠标不放 可否自动释放
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();//括号里的参数可以表示一次合成生成多少个
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddRecipeGroup("Wood", 1);

			//在合成表中添加你mod的物品
			//recipe.AddIngredient(ModContent.ItemType<sowrd>(), 1);
			//制作条件
			recipe.AddTile(TileID.WorkBenches);

			//添加环境
			//recipe.AddCondition(Condition.NearHoney);

			recipe.Register();
		}
		/* 合成组的另外一种写法
				public class TestSystem : ModSystem
				{
					public override void AddRecipeGroups()
					{
						RecipeGroup recipeGrouprecipeGroup = new RecipeGroup(() => "金或铁",
						new int[]
						{
							ItemID.GoldOre,
							ItemID.IronOre
						});
					}
				}*/

	}
}
