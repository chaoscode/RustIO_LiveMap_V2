using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6.Models.server
{
    class Items
    {
        [JsonProperty("rifle.ak", NullValueHandling = NullValueHandling.Ignore)]
        public string RifleAk { get; set; }

        [JsonProperty("ammo.handmade.shell", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoHandmadeShell { get; set; }

        [JsonProperty("ammo.pistol", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoPistol { get; set; }

        [JsonProperty("ammo.pistol.fire", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoPistolFire { get; set; }

        [JsonProperty("ammo.pistol.hv", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoPistolHv { get; set; }

        [JsonProperty("ammo.rifle", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRifle { get; set; }

        [JsonProperty("ammo.rifle.explosive", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRifleExplosive { get; set; }

        [JsonProperty("ammo.rifle.incendiary", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRifleIncendiary { get; set; }

        [JsonProperty("ammo.rifle.hv", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRifleHv { get; set; }

        [JsonProperty("ammo.rocket.basic", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRocketBasic { get; set; }

        [JsonProperty("ammo.rocket.fire", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRocketFire { get; set; }

        [JsonProperty("ammo.rocket.hv", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRocketHv { get; set; }

        [JsonProperty("ammo.rocket.smoke", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoRocketSmoke { get; set; }

        [JsonProperty("ammo.shotgun", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoShotgun { get; set; }

        [JsonProperty("ammo.shotgun.slug", NullValueHandling = NullValueHandling.Ignore)]
        public string AmmoShotgunSlug { get; set; }

        [JsonProperty("antiradpills", NullValueHandling = NullValueHandling.Ignore)]
        public string Antiradpills { get; set; }

        [JsonProperty("apple", NullValueHandling = NullValueHandling.Ignore)]
        public string Apple { get; set; }

        [JsonProperty("apple.spoiled", NullValueHandling = NullValueHandling.Ignore)]
        public string AppleSpoiled { get; set; }

        [JsonProperty("arrow.hv", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrowHv { get; set; }

        [JsonProperty("arrow.wooden", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrowWooden { get; set; }

        [JsonProperty("autoturret", NullValueHandling = NullValueHandling.Ignore)]
        public string Autoturret { get; set; }

        [JsonProperty("axe.salvaged", NullValueHandling = NullValueHandling.Ignore)]
        public string AxeSalvaged { get; set; }

        [JsonProperty("bandage", NullValueHandling = NullValueHandling.Ignore)]
        public string Bandage { get; set; }

        [JsonProperty("barricade.concrete", NullValueHandling = NullValueHandling.Ignore)]
        public string BarricadeConcrete { get; set; }

        [JsonProperty("barricade.metal", NullValueHandling = NullValueHandling.Ignore)]
        public string BarricadeMetal { get; set; }

        [JsonProperty("barricade.sandbags", NullValueHandling = NullValueHandling.Ignore)]
        public string BarricadeSandbags { get; set; }

        [JsonProperty("barricade.stone", NullValueHandling = NullValueHandling.Ignore)]
        public string BarricadeStone { get; set; }

        [JsonProperty("barricade.wood", NullValueHandling = NullValueHandling.Ignore)]
        public string BarricadeWood { get; set; }

        [JsonProperty("barricade.woodwire", NullValueHandling = NullValueHandling.Ignore)]
        public string BarricadeWoodwire { get; set; }

        [JsonProperty("battery.small", NullValueHandling = NullValueHandling.Ignore)]
        public string BatterySmall { get; set; }

        [JsonProperty("trap.bear", NullValueHandling = NullValueHandling.Ignore)]
        public string TrapBear { get; set; }

        [JsonProperty("bed", NullValueHandling = NullValueHandling.Ignore)]
        public string Bed { get; set; }

        [JsonProperty("black.raspberries", NullValueHandling = NullValueHandling.Ignore)]
        public string BlackRaspberries { get; set; }

        [JsonProperty("bleach", NullValueHandling = NullValueHandling.Ignore)]
        public string Bleach { get; set; }

        [JsonProperty("blood", NullValueHandling = NullValueHandling.Ignore)]
        public string Blood { get; set; }

        [JsonProperty("blueberries", NullValueHandling = NullValueHandling.Ignore)]
        public string Blueberries { get; set; }

        [JsonProperty("blueprintbase", NullValueHandling = NullValueHandling.Ignore)]
        public string Blueprintbase { get; set; }

        [JsonProperty("rifle.bolt", NullValueHandling = NullValueHandling.Ignore)]
        public string RifleBolt { get; set; }

        [JsonProperty("bone.club", NullValueHandling = NullValueHandling.Ignore)]
        public string BoneClub { get; set; }

        [JsonProperty("bone.fragments", NullValueHandling = NullValueHandling.Ignore)]
        public string BoneFragments { get; set; }

        [JsonProperty("botabag", NullValueHandling = NullValueHandling.Ignore)]
        public string Botabag { get; set; }

        [JsonProperty("bow.hunting", NullValueHandling = NullValueHandling.Ignore)]
        public string BowHunting { get; set; }

        [JsonProperty("box.wooden.large", NullValueHandling = NullValueHandling.Ignore)]
        public string BoxWoodenLarge { get; set; }

        [JsonProperty("box.wooden", NullValueHandling = NullValueHandling.Ignore)]
        public string BoxWooden { get; set; }

        [JsonProperty("bucket.water", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketWater { get; set; }

        [JsonProperty("building.planner", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingPlanner { get; set; }

        [JsonProperty("burlap.shirt", NullValueHandling = NullValueHandling.Ignore)]
        public string BurlapShirt { get; set; }

        [JsonProperty("burlap.shoes", NullValueHandling = NullValueHandling.Ignore)]
        public string BurlapShoes { get; set; }

        [JsonProperty("cactusflesh", NullValueHandling = NullValueHandling.Ignore)]
        public string Cactusflesh { get; set; }

        [JsonProperty("tool.camera", NullValueHandling = NullValueHandling.Ignore)]
        public string ToolCamera { get; set; }

        [JsonProperty("campfire", NullValueHandling = NullValueHandling.Ignore)]
        public string Campfire { get; set; }

        [JsonProperty("can.beans", NullValueHandling = NullValueHandling.Ignore)]
        public string CanBeans { get; set; }

        [JsonProperty("can.beans.empty", NullValueHandling = NullValueHandling.Ignore)]
        public string CanBeansEmpty { get; set; }

        [JsonProperty("can.tuna", NullValueHandling = NullValueHandling.Ignore)]
        public string CanTuna { get; set; }

        [JsonProperty("can.tuna.empty", NullValueHandling = NullValueHandling.Ignore)]
        public string CanTunaEmpty { get; set; }

        [JsonProperty("candycane", NullValueHandling = NullValueHandling.Ignore)]
        public string Candycane { get; set; }

        [JsonProperty("cctv.camera", NullValueHandling = NullValueHandling.Ignore)]
        public string CctvCamera { get; set; }

        [JsonProperty("ceilinglight", NullValueHandling = NullValueHandling.Ignore)]
        public string Ceilinglight { get; set; }

        [JsonProperty("chair", NullValueHandling = NullValueHandling.Ignore)]
        public string Chair { get; set; }

        [JsonProperty("charcoal", NullValueHandling = NullValueHandling.Ignore)]
        public string Charcoal { get; set; }

        [JsonProperty("chicken.burned", NullValueHandling = NullValueHandling.Ignore)]
        public string ChickenBurned { get; set; }

        [JsonProperty("chicken.cooked", NullValueHandling = NullValueHandling.Ignore)]
        public string ChickenCooked { get; set; }

        [JsonProperty("chicken.raw", NullValueHandling = NullValueHandling.Ignore)]
        public string ChickenRaw { get; set; }

        [JsonProperty("chicken.spoiled", NullValueHandling = NullValueHandling.Ignore)]
        public string ChickenSpoiled { get; set; }

        [JsonProperty("chocholate", NullValueHandling = NullValueHandling.Ignore)]
        public string Chocholate { get; set; }

        [JsonProperty("cloth", NullValueHandling = NullValueHandling.Ignore)]
        public string Cloth { get; set; }

        [JsonProperty("coal", NullValueHandling = NullValueHandling.Ignore)]
        public string Coal { get; set; }

        [JsonProperty("corn", NullValueHandling = NullValueHandling.Ignore)]
        public string Corn { get; set; }

        [JsonProperty("clone.corn", NullValueHandling = NullValueHandling.Ignore)]
        public string CloneCorn { get; set; }

        [JsonProperty("seed.corn", NullValueHandling = NullValueHandling.Ignore)]
        public string SeedCorn { get; set; }

        [JsonProperty("crossbow", NullValueHandling = NullValueHandling.Ignore)]
        public string Crossbow { get; set; }

        [JsonProperty("crude.oil", NullValueHandling = NullValueHandling.Ignore)]
        public string CrudeOil { get; set; }

        [JsonProperty("cupboard.tool", NullValueHandling = NullValueHandling.Ignore)]
        public string CupboardTool { get; set; }

        [JsonProperty("door.double.hinged.metal", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorDoubleHingedMetal { get; set; }

        [JsonProperty("door.double.hinged.toptier", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorDoubleHingedToptier { get; set; }

        [JsonProperty("door.double.hinged.wood", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorDoubleHingedWood { get; set; }

        [JsonProperty("door.hinged.metal", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorHingedMetal { get; set; }

        [JsonProperty("door.hinged.toptier", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorHingedToptier { get; set; }

        [JsonProperty("door.hinged.wood", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorHingedWood { get; set; }

        [JsonProperty("door.key", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorKey { get; set; }

        [JsonProperty("door.closer", NullValueHandling = NullValueHandling.Ignore)]
        public string DoorCloser { get; set; }

        [JsonProperty("ducttape", NullValueHandling = NullValueHandling.Ignore)]
        public string Ducttape { get; set; }

        [JsonProperty("explosive.satchel", NullValueHandling = NullValueHandling.Ignore)]
        public string ExplosiveSatchel { get; set; }

        [JsonProperty("explosive.timed", NullValueHandling = NullValueHandling.Ignore)]
        public string ExplosiveTimed { get; set; }

        [JsonProperty("explosives", NullValueHandling = NullValueHandling.Ignore)]
        public string Explosives { get; set; }

        [JsonProperty("fat.animal", NullValueHandling = NullValueHandling.Ignore)]
        public string FatAnimal { get; set; }

        [JsonProperty("fish.cooked", NullValueHandling = NullValueHandling.Ignore)]
        public string FishCooked { get; set; }

        [JsonProperty("fish.raw", NullValueHandling = NullValueHandling.Ignore)]
        public string FishRaw { get; set; }

        [JsonProperty("flamethrower", NullValueHandling = NullValueHandling.Ignore)]
        public string Flamethrower { get; set; }

        [JsonProperty("flameturret", NullValueHandling = NullValueHandling.Ignore)]
        public string Flameturret { get; set; }

        [JsonProperty("flare", NullValueHandling = NullValueHandling.Ignore)]
        public string Flare { get; set; }

        [JsonProperty("weapon.mod.flashlight", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponModFlashlight { get; set; }

        [JsonProperty("floor.grill", NullValueHandling = NullValueHandling.Ignore)]
        public string FloorGrill { get; set; }

        [JsonProperty("floor.ladder.hatch", NullValueHandling = NullValueHandling.Ignore)]
        public string FloorLadderHatch { get; set; }

        [JsonProperty("fridge", NullValueHandling = NullValueHandling.Ignore)]
        public string Fridge { get; set; }

        [JsonProperty("lowgradefuel", NullValueHandling = NullValueHandling.Ignore)]
        public string Lowgradefuel { get; set; }

        [JsonProperty("furnace", NullValueHandling = NullValueHandling.Ignore)]
        public string Furnace { get; set; }

        [JsonProperty("furnace.large", NullValueHandling = NullValueHandling.Ignore)]
        public string FurnaceLarge { get; set; }

        [JsonProperty("gates.external.high.stone", NullValueHandling = NullValueHandling.Ignore)]
        public string GatesExternalHighStone { get; set; }

        [JsonProperty("gates.external.high.wood", NullValueHandling = NullValueHandling.Ignore)]
        public string GatesExternalHighWood { get; set; }

        [JsonProperty("gears", NullValueHandling = NullValueHandling.Ignore)]
        public string Gears { get; set; }

        [JsonProperty("generator.wind.scrap", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratorWindScrap { get; set; }

        [JsonProperty("burlap.gloves", NullValueHandling = NullValueHandling.Ignore)]
        public string BurlapGloves { get; set; }

        [JsonProperty("glue", NullValueHandling = NullValueHandling.Ignore)]
        public string Glue { get; set; }

        [JsonProperty("granolabar", NullValueHandling = NullValueHandling.Ignore)]
        public string Granolabar { get; set; }

        [JsonProperty("grenade.beancan", NullValueHandling = NullValueHandling.Ignore)]
        public string GrenadeBeancan { get; set; }

        [JsonProperty("grenade.f1", NullValueHandling = NullValueHandling.Ignore)]
        public string GrenadeF1 { get; set; }

        [JsonProperty("fun.guitar", NullValueHandling = NullValueHandling.Ignore)]
        public string FunGuitar { get; set; }

        [JsonProperty("gunpowder", NullValueHandling = NullValueHandling.Ignore)]
        public string Gunpowder { get; set; }

        [JsonProperty("attire.hide.helterneck", NullValueHandling = NullValueHandling.Ignore)]
        public string AttireHideHelterneck { get; set; }

        [JsonProperty("hammer", NullValueHandling = NullValueHandling.Ignore)]
        public string Hammer { get; set; }

        [JsonProperty("hammer.salvaged", NullValueHandling = NullValueHandling.Ignore)]
        public string HammerSalvaged { get; set; }

        [JsonProperty("hat.beenie", NullValueHandling = NullValueHandling.Ignore)]
        public string HatBeenie { get; set; }

        [JsonProperty("hat.boonie", NullValueHandling = NullValueHandling.Ignore)]
        public string HatBoonie { get; set; }

        [JsonProperty("bucket.helmet", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketHelmet { get; set; }

        [JsonProperty("burlap.headwrap", NullValueHandling = NullValueHandling.Ignore)]
        public string BurlapHeadwrap { get; set; }

        [JsonProperty("hat.candle", NullValueHandling = NullValueHandling.Ignore)]
        public string HatCandle { get; set; }

        [JsonProperty("hat.cap", NullValueHandling = NullValueHandling.Ignore)]
        public string HatCap { get; set; }

        [JsonProperty("coffeecan.helmet", NullValueHandling = NullValueHandling.Ignore)]
        public string CoffeecanHelmet { get; set; }

        [JsonProperty("deer.skull.mask", NullValueHandling = NullValueHandling.Ignore)]
        public string DeerSkullMask { get; set; }

        [JsonProperty("heavy.plate.helmet", NullValueHandling = NullValueHandling.Ignore)]
        public string HeavyPlateHelmet { get; set; }

        [JsonProperty("hat.miner", NullValueHandling = NullValueHandling.Ignore)]
        public string HatMiner { get; set; }

        [JsonProperty("riot.helmet", NullValueHandling = NullValueHandling.Ignore)]
        public string RiotHelmet { get; set; }

        [JsonProperty("hat.wolf", NullValueHandling = NullValueHandling.Ignore)]
        public string HatWolf { get; set; }

        [JsonProperty("hatchet", NullValueHandling = NullValueHandling.Ignore)]
        public string Hatchet { get; set; }

        [JsonProperty("hazmat.boots", NullValueHandling = NullValueHandling.Ignore)]
        public string HazmatBoots { get; set; }

        [JsonProperty("hazmat.gloves", NullValueHandling = NullValueHandling.Ignore)]
        public string HazmatGloves { get; set; }

        [JsonProperty("hazmat.helmet", NullValueHandling = NullValueHandling.Ignore)]
        public string HazmatHelmet { get; set; }

        [JsonProperty("hazmat.jacket", NullValueHandling = NullValueHandling.Ignore)]
        public string HazmatJacket { get; set; }

        [JsonProperty("hazmat.pants", NullValueHandling = NullValueHandling.Ignore)]
        public string HazmatPants { get; set; }

        [JsonProperty("hazmatsuit", NullValueHandling = NullValueHandling.Ignore)]
        public string Hazmatsuit { get; set; }

        [JsonProperty("clone.hemp", NullValueHandling = NullValueHandling.Ignore)]
        public string CloneHemp { get; set; }

        [JsonProperty("seed.hemp", NullValueHandling = NullValueHandling.Ignore)]
        public string SeedHemp { get; set; }

        [JsonProperty("attire.hide.boots", NullValueHandling = NullValueHandling.Ignore)]
        public string AttireHideBoots { get; set; }

        [JsonProperty("attire.hide.skirt", NullValueHandling = NullValueHandling.Ignore)]
        public string AttireHideSkirt { get; set; }

        [JsonProperty("attire.hide.vest", NullValueHandling = NullValueHandling.Ignore)]
        public string AttireHideVest { get; set; }

        [JsonProperty("weapon.mod.holosight", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponModHolosight { get; set; }

        [JsonProperty("hoodie", NullValueHandling = NullValueHandling.Ignore)]
        public string Hoodie { get; set; }

        [JsonProperty("hq.metal.ore", NullValueHandling = NullValueHandling.Ignore)]
        public string HqMetalOre { get; set; }

        [JsonProperty("humanmeat.burned", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanmeatBurned { get; set; }

        [JsonProperty("humanmeat.cooked", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanmeatCooked { get; set; }

        [JsonProperty("humanmeat.raw", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanmeatRaw { get; set; }

        [JsonProperty("humanmeat.spoiled", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanmeatSpoiled { get; set; }

        [JsonProperty("icepick.salvaged", NullValueHandling = NullValueHandling.Ignore)]
        public string IcepickSalvaged { get; set; }

        [JsonProperty("bone.armor.suit", NullValueHandling = NullValueHandling.Ignore)]
        public string BoneArmorSuit { get; set; }

        [JsonProperty("heavy.plate.jacket", NullValueHandling = NullValueHandling.Ignore)]
        public string HeavyPlateJacket { get; set; }

        [JsonProperty("jacket.snow", NullValueHandling = NullValueHandling.Ignore)]
        public string JacketSnow { get; set; }

        [JsonProperty("jacket", NullValueHandling = NullValueHandling.Ignore)]
        public string Jacket { get; set; }

        [JsonProperty("jackolantern.angry", NullValueHandling = NullValueHandling.Ignore)]
        public string JackolanternAngry { get; set; }

        [JsonProperty("jackolantern.happy", NullValueHandling = NullValueHandling.Ignore)]
        public string JackolanternHappy { get; set; }

        [JsonProperty("knife.bone", NullValueHandling = NullValueHandling.Ignore)]
        public string KnifeBone { get; set; }

        [JsonProperty("ladder.wooden.wall", NullValueHandling = NullValueHandling.Ignore)]
        public string LadderWoodenWall { get; set; }

        [JsonProperty("trap.landmine", NullValueHandling = NullValueHandling.Ignore)]
        public string TrapLandmine { get; set; }

        [JsonProperty("lantern", NullValueHandling = NullValueHandling.Ignore)]
        public string Lantern { get; set; }

        [JsonProperty("largemedkit", NullValueHandling = NullValueHandling.Ignore)]
        public string Largemedkit { get; set; }

        [JsonProperty("weapon.mod.lasersight", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponModLasersight { get; set; }

        [JsonProperty("leather", NullValueHandling = NullValueHandling.Ignore)]
        public string Leather { get; set; }

        [JsonProperty("lock.code", NullValueHandling = NullValueHandling.Ignore)]
        public string LockCode { get; set; }

        [JsonProperty("lock.key", NullValueHandling = NullValueHandling.Ignore)]
        public string LockKey { get; set; }

        [JsonProperty("locker", NullValueHandling = NullValueHandling.Ignore)]
        public string Locker { get; set; }

        [JsonProperty("longsword", NullValueHandling = NullValueHandling.Ignore)]
        public string Longsword { get; set; }

        [JsonProperty("rifle.lr300", NullValueHandling = NullValueHandling.Ignore)]
        public string RifleLr300 { get; set; }

        [JsonProperty("lmg.m249", NullValueHandling = NullValueHandling.Ignore)]
        public string LmgM249 { get; set; }

        [JsonProperty("pistol.m92", NullValueHandling = NullValueHandling.Ignore)]
        public string PistolM92 { get; set; }

        [JsonProperty("mace", NullValueHandling = NullValueHandling.Ignore)]
        public string Mace { get; set; }

        [JsonProperty("machete", NullValueHandling = NullValueHandling.Ignore)]
        public string Machete { get; set; }

        [JsonProperty("map", NullValueHandling = NullValueHandling.Ignore)]
        public string Map { get; set; }

        [JsonProperty("mask.balaclava", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskBalaclava { get; set; }

        [JsonProperty("mask.bandana", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskBandana { get; set; }

        [JsonProperty("metal.facemask", NullValueHandling = NullValueHandling.Ignore)]
        public string MetalFacemask { get; set; }

        [JsonProperty("bearmeat.burned", NullValueHandling = NullValueHandling.Ignore)]
        public string BearmeatBurned { get; set; }

        [JsonProperty("bearmeat.cooked", NullValueHandling = NullValueHandling.Ignore)]
        public string BearmeatCooked { get; set; }

        [JsonProperty("bearmeat", NullValueHandling = NullValueHandling.Ignore)]
        public string Bearmeat { get; set; }

        [JsonProperty("meat.pork.burned", NullValueHandling = NullValueHandling.Ignore)]
        public string MeatPorkBurned { get; set; }

        [JsonProperty("meat.pork.cooked", NullValueHandling = NullValueHandling.Ignore)]
        public string MeatPorkCooked { get; set; }

        [JsonProperty("meat.boar", NullValueHandling = NullValueHandling.Ignore)]
        public string MeatBoar { get; set; }

        [JsonProperty("wolfmeat.burned", NullValueHandling = NullValueHandling.Ignore)]
        public string WolfmeatBurned { get; set; }

        [JsonProperty("wolfmeat.cooked", NullValueHandling = NullValueHandling.Ignore)]
        public string WolfmeatCooked { get; set; }

        [JsonProperty("wolfmeat.raw", NullValueHandling = NullValueHandling.Ignore)]
        public string WolfmeatRaw { get; set; }

        [JsonProperty("wolfmeat.spoiled", NullValueHandling = NullValueHandling.Ignore)]
        public string WolfmeatSpoiled { get; set; }

        [JsonProperty("metal.fragments", NullValueHandling = NullValueHandling.Ignore)]
        public string MetalFragments { get; set; }

        [JsonProperty("metal.ore", NullValueHandling = NullValueHandling.Ignore)]
        public string MetalOre { get; set; }

        [JsonProperty("metal.plate.torso", NullValueHandling = NullValueHandling.Ignore)]
        public string MetalPlateTorso { get; set; }

        [JsonProperty("metal.refined", NullValueHandling = NullValueHandling.Ignore)]
        public string MetalRefined { get; set; }

        [JsonProperty("metalblade", NullValueHandling = NullValueHandling.Ignore)]
        public string Metalblade { get; set; }

        [JsonProperty("metalpipe", NullValueHandling = NullValueHandling.Ignore)]
        public string Metalpipe { get; set; }

        [JsonProperty("mining.pumpjack", NullValueHandling = NullValueHandling.Ignore)]
        public string MiningPumpjack { get; set; }

        [JsonProperty("mining.quarry", NullValueHandling = NullValueHandling.Ignore)]
        public string MiningQuarry { get; set; }

        [JsonProperty("fish.minnows", NullValueHandling = NullValueHandling.Ignore)]
        public string FishMinnows { get; set; }

        [JsonProperty("smg.mp5", NullValueHandling = NullValueHandling.Ignore)]
        public string SmgMp5 { get; set; }

        [JsonProperty("mushroom", NullValueHandling = NullValueHandling.Ignore)]
        public string Mushroom { get; set; }

        [JsonProperty("weapon.mod.muzzleboost", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponModMuzzleboost { get; set; }

        [JsonProperty("weapon.mod.muzzlebrake", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponModMuzzlebrake { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("burlap.trousers", NullValueHandling = NullValueHandling.Ignore)]
        public string BurlapTrousers { get; set; }

        [JsonProperty("pants", NullValueHandling = NullValueHandling.Ignore)]
        public string Pants { get; set; }

        [JsonProperty("heavy.plate.pants", NullValueHandling = NullValueHandling.Ignore)]
        public string HeavyPlatePants { get; set; }

        [JsonProperty("attire.hide.pants", NullValueHandling = NullValueHandling.Ignore)]
        public string AttireHidePants { get; set; }

        [JsonProperty("roadsign.kilt", NullValueHandling = NullValueHandling.Ignore)]
        public string RoadsignKilt { get; set; }

        [JsonProperty("pants.shorts", NullValueHandling = NullValueHandling.Ignore)]
        public string PantsShorts { get; set; }

        [JsonProperty("paper", NullValueHandling = NullValueHandling.Ignore)]
        public string Paper { get; set; }

        [JsonProperty("pickaxe", NullValueHandling = NullValueHandling.Ignore)]
        public string Pickaxe { get; set; }

        [JsonProperty("pistol.eoka", NullValueHandling = NullValueHandling.Ignore)]
        public string PistolEoka { get; set; }

        [JsonProperty("pistol.revolver", NullValueHandling = NullValueHandling.Ignore)]
        public string PistolRevolver { get; set; }

        [JsonProperty("pistol.semiauto", NullValueHandling = NullValueHandling.Ignore)]
        public string PistolSemiauto { get; set; }

        [JsonProperty("planter.large", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanterLarge { get; set; }

        [JsonProperty("planter.small", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanterSmall { get; set; }

        [JsonProperty("attire.hide.poncho", NullValueHandling = NullValueHandling.Ignore)]
        public string AttireHidePoncho { get; set; }

        [JsonProperty("pookie.bear", NullValueHandling = NullValueHandling.Ignore)]
        public string PookieBear { get; set; }

        [JsonProperty("xmas.present.large", NullValueHandling = NullValueHandling.Ignore)]
        public string XmasPresentLarge { get; set; }

        [JsonProperty("xmas.present.medium", NullValueHandling = NullValueHandling.Ignore)]
        public string XmasPresentMedium { get; set; }

        [JsonProperty("xmas.present.small", NullValueHandling = NullValueHandling.Ignore)]
        public string XmasPresentSmall { get; set; }

        [JsonProperty("propanetank", NullValueHandling = NullValueHandling.Ignore)]
        public string Propanetank { get; set; }

        [JsonProperty("pumpkin", NullValueHandling = NullValueHandling.Ignore)]
        public string Pumpkin { get; set; }

        [JsonProperty("clone.pumpkin", NullValueHandling = NullValueHandling.Ignore)]
        public string ClonePumpkin { get; set; }

        [JsonProperty("seed.pumpkin", NullValueHandling = NullValueHandling.Ignore)]
        public string SeedPumpkin { get; set; }

        [JsonProperty("pistol.python", NullValueHandling = NullValueHandling.Ignore)]
        public string PistolPython { get; set; }

        [JsonProperty("target.reactive", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetReactive { get; set; }

        [JsonProperty("box.repair.bench", NullValueHandling = NullValueHandling.Ignore)]
        public string BoxRepairBench { get; set; }

        [JsonProperty("research.table", NullValueHandling = NullValueHandling.Ignore)]
        public string ResearchTable { get; set; }

        [JsonProperty("researchpaper", NullValueHandling = NullValueHandling.Ignore)]
        public string Researchpaper { get; set; }

        [JsonProperty("riflebody", NullValueHandling = NullValueHandling.Ignore)]
        public string Riflebody { get; set; }

        [JsonProperty("roadsign.jacket", NullValueHandling = NullValueHandling.Ignore)]
        public string RoadsignJacket { get; set; }

        [JsonProperty("roadsigns", NullValueHandling = NullValueHandling.Ignore)]
        public string Roadsigns { get; set; }

        [JsonProperty("rock", NullValueHandling = NullValueHandling.Ignore)]
        public string Rock { get; set; }

        [JsonProperty("rocket.launcher", NullValueHandling = NullValueHandling.Ignore)]
        public string RocketLauncher { get; set; }

        [JsonProperty("rope", NullValueHandling = NullValueHandling.Ignore)]
        public string Rope { get; set; }

        [JsonProperty("rug.bear", NullValueHandling = NullValueHandling.Ignore)]
        public string RugBear { get; set; }

        [JsonProperty("rug", NullValueHandling = NullValueHandling.Ignore)]
        public string Rug { get; set; }

        [JsonProperty("water.salt", NullValueHandling = NullValueHandling.Ignore)]
        public string WaterSalt { get; set; }

        [JsonProperty("salvaged.cleaver", NullValueHandling = NullValueHandling.Ignore)]
        public string SalvagedCleaver { get; set; }

        [JsonProperty("salvaged.sword", NullValueHandling = NullValueHandling.Ignore)]
        public string SalvagedSword { get; set; }

        [JsonProperty("santahat", NullValueHandling = NullValueHandling.Ignore)]
        public string Santahat { get; set; }

        [JsonProperty("weapon.mod.small.scope", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponModSmallScope { get; set; }

        [JsonProperty("rifle.semiauto", NullValueHandling = NullValueHandling.Ignore)]
        public string RifleSemiauto { get; set; }

        [JsonProperty("semibody", NullValueHandling = NullValueHandling.Ignore)]
        public string Semibody { get; set; }

        [JsonProperty("sewingkit", NullValueHandling = NullValueHandling.Ignore)]
        public string Sewingkit { get; set; }

        [JsonProperty("sheetmetal", NullValueHandling = NullValueHandling.Ignore)]
        public string Sheetmetal { get; set; }

        [JsonProperty("shelves", NullValueHandling = NullValueHandling.Ignore)]
        public string Shelves { get; set; }

        [JsonProperty("shirt.collared", NullValueHandling = NullValueHandling.Ignore)]
        public string ShirtCollared { get; set; }

        [JsonProperty("shirt.tanktop", NullValueHandling = NullValueHandling.Ignore)]
        public string ShirtTanktop { get; set; }

        [JsonProperty("shoes.boots", NullValueHandling = NullValueHandling.Ignore)]
        public string ShoesBoots { get; set; }

        [JsonProperty("shotgun.double", NullValueHandling = NullValueHandling.Ignore)]
        public string ShotgunDouble { get; set; }

        [JsonProperty("shotgun.pump", NullValueHandling = NullValueHandling.Ignore)]
        public string ShotgunPump { get; set; }

        [JsonProperty("shotgun.waterpipe", NullValueHandling = NullValueHandling.Ignore)]
        public string ShotgunWaterpipe { get; set; }

        [JsonProperty("shutter.metal.embrasure.a", NullValueHandling = NullValueHandling.Ignore)]
        public string ShutterMetalEmbrasureA { get; set; }

        [JsonProperty("shutter.metal.embrasure.b", NullValueHandling = NullValueHandling.Ignore)]
        public string ShutterMetalEmbrasureB { get; set; }

        [JsonProperty("shutter.wood.a", NullValueHandling = NullValueHandling.Ignore)]
        public string ShutterWoodA { get; set; }

        [JsonProperty("sign.hanging.banner.large", NullValueHandling = NullValueHandling.Ignore)]
        public string SignHangingBannerLarge { get; set; }

        [JsonProperty("sign.hanging", NullValueHandling = NullValueHandling.Ignore)]
        public string SignHanging { get; set; }

        [JsonProperty("sign.hanging.ornate", NullValueHandling = NullValueHandling.Ignore)]
        public string SignHangingOrnate { get; set; }

        [JsonProperty("sign.pictureframe.landscape", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPictureframeLandscape { get; set; }

        [JsonProperty("sign.pictureframe.portrait", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPictureframePortrait { get; set; }

        [JsonProperty("sign.pictureframe.tall", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPictureframeTall { get; set; }

        [JsonProperty("sign.pictureframe.xl", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPictureframeXl { get; set; }

        [JsonProperty("sign.pictureframe.xxl", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPictureframeXxl { get; set; }

        [JsonProperty("sign.pole.banner.large", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPoleBannerLarge { get; set; }

        [JsonProperty("sign.post.double", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPostDouble { get; set; }

        [JsonProperty("sign.post.single", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPostSingle { get; set; }

        [JsonProperty("sign.post.town", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPostTown { get; set; }

        [JsonProperty("sign.post.town.roof", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPostTownRoof { get; set; }

        [JsonProperty("sign.wooden.huge", NullValueHandling = NullValueHandling.Ignore)]
        public string SignWoodenHuge { get; set; }

        [JsonProperty("sign.wooden.large", NullValueHandling = NullValueHandling.Ignore)]
        public string SignWoodenLarge { get; set; }

        [JsonProperty("sign.wooden.medium", NullValueHandling = NullValueHandling.Ignore)]
        public string SignWoodenMedium { get; set; }

        [JsonProperty("sign.wooden.small", NullValueHandling = NullValueHandling.Ignore)]
        public string SignWoodenSmall { get; set; }

        [JsonProperty("weapon.mod.silencer", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponModSilencer { get; set; }

        [JsonProperty("skull.human", NullValueHandling = NullValueHandling.Ignore)]
        public string SkullHuman { get; set; }

        [JsonProperty("skull.wolf", NullValueHandling = NullValueHandling.Ignore)]
        public string SkullWolf { get; set; }

        [JsonProperty("sleepingbag", NullValueHandling = NullValueHandling.Ignore)]
        public string Sleepingbag { get; set; }

        [JsonProperty("small.oil.refinery", NullValueHandling = NullValueHandling.Ignore)]
        public string SmallOilRefinery { get; set; }

        [JsonProperty("stash.small", NullValueHandling = NullValueHandling.Ignore)]
        public string StashSmall { get; set; }

        [JsonProperty("fish.troutsmall", NullValueHandling = NullValueHandling.Ignore)]
        public string FishTroutsmall { get; set; }

        [JsonProperty("smallwaterbottle", NullValueHandling = NullValueHandling.Ignore)]
        public string Smallwaterbottle { get; set; }

        [JsonProperty("smg.2", NullValueHandling = NullValueHandling.Ignore)]
        public string Smg2 { get; set; }

        [JsonProperty("smgbody", NullValueHandling = NullValueHandling.Ignore)]
        public string Smgbody { get; set; }

        [JsonProperty("spear.stone", NullValueHandling = NullValueHandling.Ignore)]
        public string SpearStone { get; set; }

        [JsonProperty("spear.wooden", NullValueHandling = NullValueHandling.Ignore)]
        public string SpearWooden { get; set; }

        [JsonProperty("spikes.floor", NullValueHandling = NullValueHandling.Ignore)]
        public string SpikesFloor { get; set; }

        [JsonProperty("metalspring", NullValueHandling = NullValueHandling.Ignore)]
        public string Metalspring { get; set; }

        [JsonProperty("sticks", NullValueHandling = NullValueHandling.Ignore)]
        public string Sticks { get; set; }

        [JsonProperty("stocking.large", NullValueHandling = NullValueHandling.Ignore)]
        public string StockingLarge { get; set; }

        [JsonProperty("stocking.small", NullValueHandling = NullValueHandling.Ignore)]
        public string StockingSmall { get; set; }

        [JsonProperty("stone.pickaxe", NullValueHandling = NullValueHandling.Ignore)]
        public string StonePickaxe { get; set; }

        [JsonProperty("stonehatchet", NullValueHandling = NullValueHandling.Ignore)]
        public string Stonehatchet { get; set; }

        [JsonProperty("stones", NullValueHandling = NullValueHandling.Ignore)]
        public string Stones { get; set; }

        [JsonProperty("sulfur", NullValueHandling = NullValueHandling.Ignore)]
        public string Sulfur { get; set; }

        [JsonProperty("sulfur.ore", NullValueHandling = NullValueHandling.Ignore)]
        public string SulfurOre { get; set; }

        [JsonProperty("supply.signal", NullValueHandling = NullValueHandling.Ignore)]
        public string SupplySignal { get; set; }

        [JsonProperty("surveycharge", NullValueHandling = NullValueHandling.Ignore)]
        public string Surveycharge { get; set; }

        [JsonProperty("fishtrap.small", NullValueHandling = NullValueHandling.Ignore)]
        public string FishtrapSmall { get; set; }

        [JsonProperty("syringe.medical", NullValueHandling = NullValueHandling.Ignore)]
        public string SyringeMedical { get; set; }

        [JsonProperty("table", NullValueHandling = NullValueHandling.Ignore)]
        public string Table { get; set; }

        [JsonProperty("targeting.computer", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetingComputer { get; set; }

        [JsonProperty("tarp", NullValueHandling = NullValueHandling.Ignore)]
        public string Tarp { get; set; }

        [JsonProperty("techparts", NullValueHandling = NullValueHandling.Ignore)]
        public string Techparts { get; set; }

        [JsonProperty("smg.thompson", NullValueHandling = NullValueHandling.Ignore)]
        public string SmgThompson { get; set; }

        [JsonProperty("torch", NullValueHandling = NullValueHandling.Ignore)]
        public string Torch { get; set; }

        [JsonProperty("tshirt", NullValueHandling = NullValueHandling.Ignore)]
        public string Tshirt { get; set; }

        [JsonProperty("tshirt.long", NullValueHandling = NullValueHandling.Ignore)]
        public string TshirtLong { get; set; }

        [JsonProperty("tunalight", NullValueHandling = NullValueHandling.Ignore)]
        public string Tunalight { get; set; }

        [JsonProperty("vending.machine", NullValueHandling = NullValueHandling.Ignore)]
        public string VendingMachine { get; set; }

        [JsonProperty("wall.external.high.stone", NullValueHandling = NullValueHandling.Ignore)]
        public string WallExternalHighStone { get; set; }

        [JsonProperty("wall.external.high", NullValueHandling = NullValueHandling.Ignore)]
        public string WallExternalHigh { get; set; }

        [JsonProperty("wall.frame.cell.gate", NullValueHandling = NullValueHandling.Ignore)]
        public string WallFrameCellGate { get; set; }

        [JsonProperty("wall.frame.cell", NullValueHandling = NullValueHandling.Ignore)]
        public string WallFrameCell { get; set; }

        [JsonProperty("wall.frame.fence.gate", NullValueHandling = NullValueHandling.Ignore)]
        public string WallFrameFenceGate { get; set; }

        [JsonProperty("wall.frame.fence", NullValueHandling = NullValueHandling.Ignore)]
        public string WallFrameFence { get; set; }

        [JsonProperty("wall.frame.shopfront", NullValueHandling = NullValueHandling.Ignore)]
        public string WallFrameShopfront { get; set; }

        [JsonProperty("wall.frame.shopfront.metal", NullValueHandling = NullValueHandling.Ignore)]
        public string WallFrameShopfrontMetal { get; set; }

        [JsonProperty("wall.window.bars.metal", NullValueHandling = NullValueHandling.Ignore)]
        public string WallWindowBarsMetal { get; set; }

        [JsonProperty("wall.window.bars.toptier", NullValueHandling = NullValueHandling.Ignore)]
        public string WallWindowBarsToptier { get; set; }

        [JsonProperty("wall.window.bars.wood", NullValueHandling = NullValueHandling.Ignore)]
        public string WallWindowBarsWood { get; set; }

        [JsonProperty("water", NullValueHandling = NullValueHandling.Ignore)]
        public string Water { get; set; }

        [JsonProperty("water.catcher.large", NullValueHandling = NullValueHandling.Ignore)]
        public string WaterCatcherLarge { get; set; }

        [JsonProperty("water.catcher.small", NullValueHandling = NullValueHandling.Ignore)]
        public string WaterCatcherSmall { get; set; }

        [JsonProperty("water.barrel", NullValueHandling = NullValueHandling.Ignore)]
        public string WaterBarrel { get; set; }

        [JsonProperty("waterjug", NullValueHandling = NullValueHandling.Ignore)]
        public string Waterjug { get; set; }

        [JsonProperty("water.purifier", NullValueHandling = NullValueHandling.Ignore)]
        public string WaterPurifier { get; set; }

        [JsonProperty("wood", NullValueHandling = NullValueHandling.Ignore)]
        public string Wood { get; set; }

        [JsonProperty("wood.armor.jacket", NullValueHandling = NullValueHandling.Ignore)]
        public string WoodArmorJacket { get; set; }

        [JsonProperty("wood.armor.pants", NullValueHandling = NullValueHandling.Ignore)]
        public string WoodArmorPants { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("founded", NullValueHandling = NullValueHandling.Ignore)]
        public long? Founded { get; set; }

        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Members { get; set; }
    }
}
