using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddysConsoleAdventureRPG
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        //weapons
        public const int ITEM_ID_WOODEN_SWORD = 1;
        public const int ITEM_ID_IRON_SWORD = 2;
        public const int ITEM_ID_WOODEN_HATCHET = 3;
        public const int ITEM_ID_IRON_AXE = 4;
        public const int ITEM_ID_GOLDEN_SWORD = 5;
        public const int ITEM_ID_GOLDEN_AXE = 6;
        public const int ITEM_ID_KATANA = 7;
        public const int ITEM_ID_BANDIT_DAGGER = 8;
        
        //mob drops
        public const int ITEM_ID_SPIDER_FANG = 20;
        public const int ITEM_ID_SPIDER_EYE = 21;
        public const int ITEM_ID_WOLF_TOOTH = 22;
        public const int ITEM_ID_WOLF_FUR = 23;
        public const int ITEM_ID_BEAR_TOOTH = 24;
        public const int ITEM_ID_BEAR_FUR = 25;
        public const int ITEM_ID_SKELETON_BONE = 26;
        public const int ITEM_ID_RAW_MEAT = 27;
        public const int ITEM_ID_RAT_TAIL = 28;
        public const int ITEM_ID_RAT_FUR = 29;
        public const int ITEM_ID_BANDIT_SCARF = 30;

        //healing potions
        public const int ITEM_ID_HEALING_POTION = 35;
        public const int ITEM_ID_BIG_HEALING_POTION = 36;

        //armor
        public const int ITEM_ID_LEATHER_BOOTS = 40;
        public const int ITEM_ID_LEATHER_PANTS = 41;
        public const int ITEM_ID_LEATHER_BREASTPLATE = 42;
        public const int ITEM_ID_LEATHER_HELMET = 43;
        public const int ITEM_ID_IRON_BOOTS = 44;
        public const int ITEM_ID_IRON_PANTS = 45;
        public const int ITEM_ID_IRON_BREASTPLATE = 46;
        public const int ITEM_ID_IRON_HELMET = 47;
        public const int ITEM_ID_GOLDEN_BOOTS = 48;
        public const int ITEM_ID_GOLDEN_PANTS = 49;
        public const int ITEM_ID_GOLDEN_BREASTPLATE = 50;
        public const int ITEM_ID_GOLDEN_HELMET = 51;

        //misc items
        public const int ITEM_ID_GOLD_INGOT = 60;
        public const int ITEM_ID_HERO_MEDAL = 61;
        public const int ITEM_ID_WHEAT = 62;
        public const int ITEM_ID_BEER = 63;
        public const int ITEM_ID_WOODEN_STICK = 64;
        public const int ITEM_ID_ROSE = 65;
        public const int ITEM_ID_GOLDEN_RING = 66;
        public const int ITEM_ID_LOVE_LETTER = 67;
        public const int ITEM_ID_UNCURED_WEED = 68;
        public const int ITEM_ID_JOINT = 69;
        public const int ITEM_ID_HOLY_PENDANT = 70;
        public const int ITEM_ID_HOLY_SCROLL = 71;

        //food
        public const int ITEM_ID_BREAD = 80;
        public const int ITEM_ID_APPLE = 81;
        public const int ITEM_ID_MEAT_SOUP = 82;

        //mobs
        public const int MONSTER_ID_GIANT_SPIDER = 1;
        public const int MONSTER_ID_WOLF = 2;
        public const int MONSTER_ID_BEAR = 3;
        public const int MONSTER_ID_SKELETON = 4;
        public const int MONSTER_ID_GIANT_RAT = 5;
        public const int MONSTER_ID_BANDIT = 6;

        //quests
        public const int QUEST_ID_GO_TO_CITY = 1;
        public const int QUEST_ID_VISIT_CAMP = 2;
        public const int QUEST_ID_HUNT_SPIDERS = 3;
        public const int QUEST_ID_RAW_MEAT_FOR_THE_COOK = 4;
        public const int QUEST_ID_FUR_FOR_ARMOR = 5;
        public const int QUEST_ID_CLEAR_OUT_BASEMENT = 6;
        public const int QUEST_ID_CLEAR_OUT_GRAVEYARD = 7;
        public const int QUEST_ID_WOLF_PROBLEM = 8;
        public const int QUEST_ID_BEAR_PROBLEM = 9;
        public const int QUEST_ID_BEER_FOR_THE_ADVENTURERS = 10;
        public const int QUEST_ID_BANDIT_THREAT = 11;
        public const int QUEST_ID_WE_NEED_BREAD = 12;

        public const int LOCATION_ID_WOODEN_HUT = 1;
        public const int LOCATION_ID_FOREST_NORTH = 2;
        public const int LOCATION_ID_FOREST_EAST = 3;
        public const int LOCATION_ID_FOREST_SOUTH = 4;
        public const int LOCATION_ID_FOREST_WEST = 5;
        public const int LOCATION_ID_CAMPSITE = 6;
        public const int LOCATION_ID_CITY_ENTRANCE = 7;
        public const int LOCATION_ID_CITY_CENTRE = 8;
        public const int LOCATION_ID_CITY_MERCHANT_SQUARE = 9;
        public const int LOCATION_ID_CITY_TAVERN = 10;
        public const int LOCATION_ID_CITY_TAVERN_BASEMENT = 11;
        public const int LOCATION_ID_CITY_TEMPLE = 12;
        public const int LOCATION_ID_GRAVEYARD = 13;
        public const int LOCATION_ID_WHEAT_FIELD = 14;
        public const int LOCATION_ID_FARMERS_HOUSE = 15;
        public const int LOCATION_ID_FLOWER_FIELD = 16;

        static World() //populate world with stuff
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            //add weapons
            Items.Add(new Weapon(ITEM_ID_WOODEN_SWORD, "Wooden Sword", "Wooden Swords", 5, 0.5f, 1, 4));
            Items.Add(new Weapon(ITEM_ID_IRON_SWORD, "Iron Sword", "Iron Swords", 10, 0.8f, 3, 6));
            Items.Add(new Weapon(ITEM_ID_WOODEN_HATCHET, "Wooden Hatchet", "Wooden Hatchets", 6, 0.4f, 1, 3));
            Items.Add(new Weapon(ITEM_ID_IRON_AXE, "Iron Axe", "Iron Axes", 5, 0.9f, 12, 5));
            Items.Add(new Weapon(ITEM_ID_GOLDEN_SWORD, "Golden Sword", "Golden Swords", 30, 0.4f, 5, 9));
            Items.Add(new Weapon(ITEM_ID_GOLDEN_AXE, "Golden Axe", "Golden Axes", 35, 0.5f, 6, 8));
            Items.Add(new Weapon(ITEM_ID_KATANA, "Katana", "Katanas", 50, 1.0f, 9, 13));
            Items.Add(new Weapon(ITEM_ID_BANDIT_DAGGER, "Bandit Dagger", "Bandit Daggers", 7, 0.2f, 3, 4));

            //add mob drops
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider Fang", "Spider Fangs", 2, 0.05f));
            Items.Add(new Item(ITEM_ID_SPIDER_EYE, "Spider Eye", "Spider Eyes", 4, 0.1f));
            Items.Add(new Item(ITEM_ID_WOLF_TOOTH, "Wolf Tooth", "Wolf Teeth", 3, 0.05f));
            Items.Add(new Item(ITEM_ID_WOLF_FUR, "Wolf Fur", "Wolf Fur", 6, 0.2f));
            Items.Add(new Item(ITEM_ID_BEAR_TOOTH, "Bear Tooth", "Bear Teeth", 3, 0.05f));
            Items.Add(new Item(ITEM_ID_BEAR_FUR, "Bear Fur", "Bear Fur", 7, 0.2f));
            Items.Add(new Item(ITEM_ID_RAW_MEAT, "Raw Meat", "Raw Meat(s)", 3, 0.15f));
            Items.Add(new Item(ITEM_ID_SKELETON_BONE, "Skeleton Bone", "Skeleton Bones", 6, 0.1f));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat Tail", "Rat Tails", 2, 0.05f));
            Items.Add(new Item(ITEM_ID_RAT_FUR, "Rat Fur", "Rat Fur", 3, 0.1f));
            Items.Add(new Item(ITEM_ID_BANDIT_SCARF, "Bandit Scarf", "Bandit Scarfs", 8, 0.15f));

            //add healing potions
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing Potion", "Healing Potions", 4, 0.02f, 5));
            Items.Add(new HealingPotion(ITEM_ID_BIG_HEALING_POTION, "Big Healing Potion", "Big Healing Potions", 8, 0.04f, 10));

            //armor
            Items.Add(new Armor(ITEM_ID_LEATHER_BOOTS, "Leather Boots", "Leather Boots'", 8, 1.5f, 2));
            Items.Add(new Armor(ITEM_ID_LEATHER_PANTS, "Leather Pants", "Leather Pants'", 10, 2.0f, 3));
            Items.Add(new Armor(ITEM_ID_LEATHER_BREASTPLATE, "Leather Breastplate", "Leather Breastplates", 10, 2.0f, 3));
            Items.Add(new Armor(ITEM_ID_LEATHER_HELMET, "Leather Helmet", "Leather Helmets", 9, 1.0f, 2));
            Items.Add(new Armor(ITEM_ID_IRON_BOOTS, "Iron Boots", "Iron Boots'", 15, 2.0f, 4));
            Items.Add(new Armor(ITEM_ID_IRON_PANTS, "Íron Pants", "Iron Pants'", 18, 2.5f, 6));
            Items.Add(new Armor(ITEM_ID_IRON_BREASTPLATE, "Iron Breastplate", "Iron Breastplates", 18, 2.5f, 6));
            Items.Add(new Armor(ITEM_ID_IRON_HELMET, "Iron Helmet", "Iron Helmets", 17, 1.5f, 4));
            Items.Add(new Armor(ITEM_ID_GOLDEN_BOOTS, "Golden Boots", "Golden Boots'", 30, 1.7f, 7));
            Items.Add(new Armor(ITEM_ID_GOLDEN_PANTS, "Golden Pants", "Golden Pants'", 35, 2.2f, 9));
            Items.Add(new Armor(ITEM_ID_GOLDEN_BREASTPLATE, "Golden Breastplate", "Golden Breastplates", 35, 2.2f, 9));
            Items.Add(new Armor(ITEM_ID_GOLDEN_HELMET, "Golden Helmet", "Golden Helmets", 33, 1.2f, 7));

            //misc items
            Items.Add(new Item(ITEM_ID_GOLD_INGOT, "Gold Ingots", "Gold Ingots", 20, 1.0f));
            Items.Add(new Item(ITEM_ID_HERO_MEDAL, "Hero Medal", "Hero Medals", 25, 0.1f));
            Items.Add(new Item(ITEM_ID_WHEAT, "Wheat", "Wheat'", 3, 0.3f));
            Items.Add(new Item(ITEM_ID_BEER, "Beer", "Beers", 7, 0.7f));
            Items.Add(new Item(ITEM_ID_WOODEN_STICK, "Wooden Stick", "Wooden Sticks", 2, 0.05f));
            Items.Add(new Item(ITEM_ID_ROSE, "Rose", "Roses", 5, 0.05f));
            Items.Add(new Item(ITEM_ID_GOLDEN_RING, "Golden Ring", "Golden Rings", 40, 0.1f));
            Items.Add(new Item(ITEM_ID_LOVE_LETTER, "Love Letter", "Love Letters", 10, 0.2f));
            Items.Add(new Item(ITEM_ID_UNCURED_WEED, "Uncured Weed", "Uncured Weed'", 5, 0.5f));
            Items.Add(new Item(ITEM_ID_JOINT, "Joint", "Joints", 7, 0.25f));
            Items.Add(new Item(ITEM_ID_HOLY_PENDANT, "Holy Pendant", "Holy Pendants", 50, 0.2f));
            Items.Add(new Item(ITEM_ID_HOLY_SCROLL, "Holy Scroll", "Holy Scrolls", 45, 0.3f));

            //food
            Items.Add(new Food(ITEM_ID_BREAD, "Bread", "Bread(s)", 8, 0.3f, 3, 4));
            Items.Add(new Food(ITEM_ID_APPLE, "Apple", "Apples", 3, 0.1f, 1, 2));
            Items.Add(new Food(ITEM_ID_MEAT_SOUP, "Meat Soup", "Meat Soups", 11, 0.4f, 5, 6));

            //more items are coming. My plan is to make beer and joints consumable. They will give you stat increases in battle.
        }

        private static void PopulateMonsters()
        {
            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant Spider", 5, 4, 14, 9, 18, 18);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 70, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_EYE), 30, true));

            Monsters.Add(giantSpider);

            Monster wolf = new Monster(MONSTER_ID_WOLF, "Wolf", 5, 5, 15, 10, 17, 17);
            wolf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_TOOTH), 75, true));
            wolf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_FUR), 25, true));
            wolf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAW_MEAT), 25, true));

            Monsters.Add(wolf);

            Monster bear = new Monster(MONSTER_ID_BEAR, "Bear", 6, 6, 18, 11, 20, 20);
            bear.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEAR_TOOTH), 75, true));
            bear.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEAR_FUR), 25, true));
            bear.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAW_MEAT), 25, true));

            Monsters.Add(bear);

            Monster skeleton = new Monster(MONSTER_ID_SKELETON, "Skeleton", 8, 4, 20, 13, 13, 13);
            skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SKELETON_BONE), 50, true));

            Monsters.Add(skeleton);

            Monster giantRat = new Monster(MONSTER_ID_GIANT_RAT, "Giant Rat", 2, 1, 8, 4, 10, 10);
            giantRat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 70, true));
            giantRat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_FUR), 30, true));

            Monsters.Add(giantRat);

            Monster bandit = new Monster(MONSTER_ID_SKELETON, "Bandit", 8, 6, 25, 16, 20, 20);
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BANDIT_SCARF), 80, true));
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BANDIT_DAGGER), 20, true));
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOLD_INGOT), 5, true));

            Monsters.Add(bandit);

            //more (endgame) monsters are coming
        }

        private static void PopulateQuests()
        {
            Quest goToCity = new Quest(QUEST_ID_GO_TO_CITY, "Go to town",
                                       "Niclas, the doctor, said you should probably go to city. You will receive a wooden sword once you go there.", 10, 10);

            goToCity.RewardItem = ItemByID(ITEM_ID_WOODEN_SWORD);

            Quest visitCamp = new Quest(QUEST_ID_VISIT_CAMP, "Visit camp",
                                        "You could go visit the camp and say hello to the people there. Maybe they can tell you something about this place or give you some items that could help you on your way.", 5, 5);

            visitCamp.RewardItem = ItemByID(ITEM_ID_APPLE);

            Quest huntSpiders = new Quest(QUEST_ID_HUNT_SPIDERS, "Hunt spiders",
                                          "Some people in the city are afraid of the giant spiders in the forest. Who wouldn't be? Kill some of them and bring back 3 spider fangs. You will receive some gold and a healing potion.", 25, 15);

            huntSpiders.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SPIDER_FANG), 3));

            huntSpiders.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest rawMeatForTheCook = new Quest(QUEST_ID_RAW_MEAT_FOR_THE_COOK, "Raw Meat for the Cook",
                                                "The cook from the city asked you to bring back 4 pieces of raw meat from creatures living in the forest. Kill wolves and bears         until you have enough and he will let you taste one of his meals.", 30, 20);

            rawMeatForTheCook.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAW_MEAT), 4));

            rawMeatForTheCook.RewardItem = ItemByID(ITEM_ID_MEAT_SOUP);

            Quest furForArmor = new Quest(QUEST_ID_FUR_FOR_ARMOR, "Fur for Armor",
                                          "The smith needs more fur. Kill wolves and bears until you get 2 wolf and 2 bear fur and you will receive a Leather Breastplate.", 25, 15);

            furForArmor.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WOLF_FUR), 2));
            furForArmor.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BEAR_FUR), 2));

            furForArmor.RewardItem = ItemByID(ITEM_ID_LEATHER_BREASTPLATE);

            Quest clearOutBasement = new Quest(QUEST_ID_CLEAR_OUT_BASEMENT, "Clear out Basement",
                                               "The inhabitants of the city are uncomfortable with the rats down in the taverns basement. Kill some of them and bring back 7 rat       tails.", 20, 15);

            clearOutBasement.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 7));

            clearOutBasement.RewardItem = ItemByID(ITEM_ID_BREAD);

            Quest clearOutGraveyard = new Quest(QUEST_ID_CLEAR_OUT_GRAVEYARD, "Clear out Graveyard",
                                                "There seems to be a graveyard near the city which is haunted by skeletons. Kill some of them until you have 3 skeleton bones and       then come back to receive a weapon.", 30, 10);

            clearOutGraveyard.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SKELETON_BONE), 3));

            clearOutGraveyard.RewardItem = ItemByID(ITEM_ID_IRON_AXE);

            Quest wolfProblem = new Quest(QUEST_ID_WOLF_PROBLEM, "Wolf Problem",
                                          "The wolves are close to overruning the city. The guards can't keep up with them. You have to go out and kill enough. Bring back 10 wolf teeth as proof. The smith will give you Iron Pants as a thank you.", 40, 25);

            wolfProblem.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WOLF_TOOTH), 10));

            wolfProblem.RewardItem = ItemByID(ITEM_ID_IRON_PANTS);

            Quest bearProblem = new Quest(QUEST_ID_BEAR_PROBLEM, "Bear Problem",
                              "The bears are close to overruning the city. The guards can't keep up with them. You have to go out and kill enough. Bring back 10 bear teeth as proof. The smith will give you a Iron Breastplate as a thank you.", 40, 30);

            bearProblem.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BEAR_TOOTH), 10));

            bearProblem.RewardItem = ItemByID(ITEM_ID_IRON_BREASTPLATE);

            Quest beerForTheAdventurers = new Quest(QUEST_ID_BEER_FOR_THE_ADVENTURERS, "Beer for the Adventurers",
                                                    "The tavern has no beer left. Travelers and Adventurers visting are upset. Head to the Wheat Field and collect 5 wheat to               satisfy their drinking addiction.", 15, 15);

            beerForTheAdventurers.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WHEAT), 5));

            beerForTheAdventurers.RewardItem = ItemByID(ITEM_ID_BEER);

            Quest banditThreat = new Quest(QUEST_ID_BANDIT_THREAT, "Bandit Threat",
                                           "Locals have heard that some bandits are planning to take over the city. You have to prevent them. Bring back 10 bandit scarfs as proof that you did something. You will receive a hero medal, which will grant you access to the city temple.", 50, 30);

            banditThreat.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BANDIT_SCARF), 10));

            banditThreat.RewardItem = ItemByID(ITEM_ID_HERO_MEDAL);

            Quest weNeedBread = new Quest(QUEST_ID_WE_NEED_BREAD, "We need Bread",
                                          "The tavern has run out of bread to serve. Looks like you have to go to the wheat field. Bring back 10 wheat and you will receive an iron helmet.", 20, 10);

            weNeedBread.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WHEAT), 10));

            weNeedBread.RewardItem = ItemByID(ITEM_ID_IRON_HELMET);

            Quests.Add(goToCity);
            Quests.Add(visitCamp);
            Quests.Add(huntSpiders);
            Quests.Add(rawMeatForTheCook);
            Quests.Add(furForArmor);
            Quests.Add(clearOutBasement);
            Quests.Add(clearOutGraveyard);
            Quests.Add(wolfProblem);
            Quests.Add(bearProblem);
            Quests.Add(beerForTheAdventurers);
            Quests.Add(banditThreat);
            Quests.Add(weNeedBread);
            //more quests are coming
        }

        private static void PopulateLocations()
        {
            Location woodenHut = new Location(LOCATION_ID_WOODEN_HUT, "Wooden Hut", "This is the place where you woke up.");
            woodenHut.QuestAvailable1 = QuestByID(QUEST_ID_GO_TO_CITY);
            woodenHut.QuestAvailable2 = QuestByID(QUEST_ID_VISIT_CAMP);

            Location forestNorth = new Location(LOCATION_ID_FOREST_NORTH, "Forest North", "The northern part of the forest.");
            forestNorth.MobToBattle1 = MonsterByID(MONSTER_ID_WOLF);
            forestNorth.MobToBattle2 = MonsterByID(MONSTER_ID_BANDIT);

            Location forestEast = new Location(LOCATION_ID_FOREST_EAST, "Forest East", "The eastern part of the forest.");
            forestEast.MobToBattle1 = MonsterByID(MONSTER_ID_BEAR);
            forestEast.MobToBattle2 = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location forestSouth = new Location(LOCATION_ID_FOREST_SOUTH, "Forest South", "The southern part of the forest.");
            forestSouth.MobToBattle1 = MonsterByID(MONSTER_ID_WOLF);
            forestSouth.MobToBattle2 = MonsterByID(MONSTER_ID_BEAR);

            Location forestWest = new Location(LOCATION_ID_FOREST_WEST, "Forest West", "The western part of the forest.");
            forestWest.MobToBattle1 = MonsterByID(MONSTER_ID_BANDIT);
            forestWest.MobToBattle2 = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location campSite = new Location(LOCATION_ID_CAMPSITE, "Campsite", "A campsite popular with adventurers and travelers.");

            Location cityEntrance = new Location(LOCATION_ID_CITY_ENTRANCE, "City Entrance", "The entrance to the city.");
            cityEntrance.QuestAvailable1 = QuestByID(QUEST_ID_HUNT_SPIDERS);

            Location cityCentre = new Location(LOCATION_ID_CITY_CENTRE, "City Centre", "The centre of the city.");
            cityCentre.QuestAvailable1 = QuestByID(QUEST_ID_WOLF_PROBLEM);
            cityCentre.QuestAvailable2 = QuestByID(QUEST_ID_BEAR_PROBLEM);

            Location cityMerchantSquare = new Location(LOCATION_ID_CITY_MERCHANT_SQUARE, "Merchant Square", "This is the part of the city where merchants reside.");
            cityMerchantSquare.QuestAvailable1 = QuestByID(QUEST_ID_RAW_MEAT_FOR_THE_COOK);
            cityMerchantSquare.QuestAvailable2 = QuestByID(QUEST_ID_FUR_FOR_ARMOR);

            Location cityTavern = new Location(LOCATION_ID_CITY_TAVERN, "Tavern", "The tavern. Adventurers and Travelers gather here to relax and exchange stories.");
            cityTavern.QuestAvailable1 = QuestByID(QUEST_ID_CLEAR_OUT_BASEMENT);
            cityTavern.QuestAvailable2 = QuestByID(QUEST_ID_BEER_FOR_THE_ADVENTURERS);
            cityTavern.QuestAvailable3 = QuestByID(QUEST_ID_WE_NEED_BREAD); 

            Location cityTavernBasement = new Location(LOCATION_ID_CITY_TAVERN_BASEMENT, "Tavern Basement", "The taverns basement. Everything that's needed is stored here. Seems                                                                                                   to be infested with rats.");
            cityTavernBasement.MobToBattle1 = MonsterByID(MONSTER_ID_GIANT_RAT);

            Location cityTemple = new Location(LOCATION_ID_CITY_TEMPLE, "City Temple", "A holy temple only accessible by adventurers, who have proven themself worthy.");

            Location graveYard = new Location(LOCATION_ID_GRAVEYARD, "Graveyard", "A place to mourn the fallen.");
            graveYard.MobToBattle1 = MonsterByID(MONSTER_ID_SKELETON);

            Location wheatField = new Location(LOCATION_ID_WHEAT_FIELD, "Wheat Field", "A field which belongs to the farmer. Wheat is planted here.");

            Location farmersHouse = new Location(LOCATION_ID_FARMERS_HOUSE, "Farmers House", "The farmers house.");

            Location flowerField = new Location(LOCATION_ID_FLOWER_FIELD, "Flower Field", "A flower field.");

            woodenHut.LocationToNorth = forestNorth;
            woodenHut.LocationToEast = forestEast;
            woodenHut.LocationToSouth = forestSouth;
            woodenHut.LocationToWest = forestWest;

            forestSouth.LocationToSouth = campSite;
            forestSouth.LocationToNorth = woodenHut;

            campSite.LocationToNorth = forestSouth;

            forestEast.LocationToEast = flowerField;
            forestEast.LocationToWest = woodenHut;

            flowerField.LocationToWest = forestEast;

            forestNorth.LocationToNorth = cityEntrance;
            forestNorth.LocationToSouth = woodenHut;

            forestWest.LocationToWest = farmersHouse;
            forestWest.LocationToEast = woodenHut;

            farmersHouse.LocationToNorth = wheatField;
            farmersHouse.LocationToEast = forestWest;

            wheatField.LocationToSouth = farmersHouse;

            cityEntrance.LocationToNorth = cityCentre;
            cityEntrance.LocationToSouth = forestNorth;

            cityCentre.LocationToNorth = cityTavern;
            cityCentre.LocationToEast = cityMerchantSquare;
            cityCentre.LocationToSouth = cityEntrance;
            cityCentre.LocationToWest = graveYard;

            cityTavern.LocationToNorth = cityTavernBasement;
            cityTavern.LocationToSouth = cityCentre;

            graveYard.LocationToEast = cityCentre;

            cityMerchantSquare.LocationToEast = cityTemple;
            cityMerchantSquare.LocationToWest = cityCentre;

            cityTemple.LocationToWest = cityMerchantSquare;

            Locations.Add(woodenHut);
            Locations.Add(forestNorth);
            Locations.Add(forestEast);
            Locations.Add(forestSouth);
            Locations.Add(forestWest);
            Locations.Add(campSite);
            Locations.Add(cityEntrance);
            Locations.Add(cityCentre);
            Locations.Add(cityMerchantSquare);
            Locations.Add(cityTavern);
            Locations.Add(cityTavernBasement);
            Locations.Add(cityTemple);
            Locations.Add(graveYard);
            Locations.Add(wheatField);
            Locations.Add(farmersHouse);
            Locations.Add(flowerField);
        }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }

        //public static void ChangeLocation(Character _character, Location newLocation) //need to implement a way of moving locations
        //{
        //    _character.CurrentLocation = woodenHut; //need to move this to game start 

        //    switch (InputManager.MoveInput("Where do you want to go?", "1 - North", "2 - East", "3 - South", "4 - West"))
        //    {
        //        case 1: _character.CurrentLocation = newLocation;
        //    }


        //}

    }


   
}
