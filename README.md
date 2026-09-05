# 3DS Terraria Decompilation/Reverse Engineering
### This is for Terraria 3DS versions 1.0.5 (Update Code: v5.6.0).
### This is not a redistribution, no source code/memory is downloadable.
This is some information about a 3DS Terraria decompaction. This was obtain via a ram dump, not from a cartredge dump.
The decompilation was done in Binary Ninja because Ghidra can not decompile the ridiculously large jump table Terraria uses.
So far everything was gotten manually so names, types and other things could be wrong, especially for non-Terraria functions.
<br/>
<br/>
Code was compared to Terraria Versions around 1.2.4.1 but may contain code from some 1.3 versions.
<br/>
<br/>
Unfortunately the free versions of Binary Ninja does not allow exporting functions/variable data,
and the Binary Ninja save file would be distributing the memory which would be illegal,
also the save file is over 1GB and idk if GitHub would like that,
so idk how often this will be updated.
<br/>

# Modding
There is not much information about 3DS Terraria modding (other them people wanting to port modern Terraria or Calamity for some reason) it seems.
There is some effort to mod it however.<br/>
[Working vein miner](https://www.reddit.com/r/Terraria/comments/1votqoj/successfully_modded_terraria_for_3ds/) (the impressive part is they got UI elements drawn, no ideal how they did that).<br/>
[Rom hack that change the music](https://www.gamebrew.org/wiki/Terratale_3DS)<br/>
[Inventory Editor](https://www.reddit.com/r/Terraria/comments/1votqoj/successfully_modded_terraria_for_3ds/) (not really a mod)<br/>
There are also some cheats exist through [Checkpoint](https://github.com/JourneyOver/CTRPF-AR-CHEAT-CODES/blob/master/Cheats/Terraria%20(USA)/000400000016A900.txt)
but these are not live mods.

# Memory
These are the important ones, there is an attached image of all of them.<br/>
These are virtual addresses.<br/>
I think all 3DS programs start at `0x00100000` (Rosalina is the only i found that does not)<br/>
The heap is almost always at `0x080000000` and i think all programs end at `0x40000000`.

| Start        | End          | Length       | Flags | Name |
| -----        | ---          | ------       | ----- | ---- |
| `0x00100000` | `0x005C1000` | `0x004C1000` | r-x   | .text |
| `0x005C1000` | `0x00629000` | `0x00068000` | r--   | .rodata |
| `0x00629000` | `0x008B5000` | `0x0028C000` | rw-   | .data(/.bss?) |
| `0x008B8000` | `0x008DC000` | `0x00024000` | rw-   | other (.bss?) |
| `0x008DC000` | `0x80000000` | `0x07724000` | ---   | Free |
| `0x08000000` | `0x0AAE4000` | `0x02AE4000` | rw-   | Heap |
|  |  |  |  |  |
| `0x30000000` | `0x34900000`\* | `0x04900000`\* | rw-   | "Continuous" |

\*`0x04900000`, may change sizes depending on if its a new or old 3DS (i think this is for the New 3DS XL).<br/>

Note: For some reason .rodata/.bss have a size of `0x002B3000` while another section at the same location has a size of `0x0028C000`, im not sure whats going on here, maybe .bss is not the same section as .data but idk.<br/>
Note for modders: a lot of memory after `0x008DC000` is free

# Functions
Naming may fallow `[FunctionName]_[ClassName]` where the ClassName was referenced from actual Terraria.
These names may also be renamed to be more understandable.

| Address      | Function Signature                                                       | Description
| ------------ | ------------------------------------------------------------------------ | - |
| `0x001006de` | `void* ForEach(void* elms, u32 count, u32 elmSize, void void* foo)` | Runs `foo` for every element in `elms`. |
| `0x00101042` | `u32 Utf16_strlen(u16* utf16_str)` | `strlen()` for a utf16 string. |
| `0x00101042` | `u32 Utf16_strcmp(u16* str1, u16* str2, u32 length)` | `strcmp()` for a utf16 string. |
| `0x00101042` | `int32_t _cfguInit()` | Inits the 3DSs `cfg:u` service. |
| `0x00115198` | `void CreateColour(Colour* c, u32 R, u32 G, u32 B, u32 A)` | Creates a colour struct. |
| `0x0011ec7c` | `void ClearItem2(Item* item)` | Clears some item properties. |
| `0x00137c24` | `void ShowPopup(String* string)` |
| `0x0013b8cc` | `void ClearItem(Item* item)` | Clears some item properties. |
| `0x0013bac4` | `void PlaySound(s32 soundId)` | Plays a sound with a given id. |
| `0x0013f940` | `int32_t RandomNumber(int32_t* arg1, int32_t arg2)` |
| `0x0013f9b4` | `s32 RandomNumberRange(int128_t* seed, s32 min, s32 max)` |
| `0x0014a24c` | `ImageLoader* ClearImageLoader(ImageLoader* arg1)` | Clears some data relating to what seems to be an image loader. |
| `0x0014f7b8` | `void* FreeStringType2(String* str)` |
| `0x00152090` | `String* CreateStringType(String* str1, char* rawStr)` |
| `0x0015d71c` | `u32 MurmurHash3(String* string, u32 seed)` |
| `0x0017e3f4` | `void LoadBackground()` | Loads Terraria's background images. |
| `0x00180054` | `void DrawBackground(void* arg1, u32 backgroundType, int32_t arg3, Colour colour1 @ r9, int32_t arg5 @ r11, int32_t arg6, int32_t arg7)` | Draws a background. |
| `0x001ab3a0` | `uint32_t Kill_Projectile(Projectile* projectile, int128_t arg2 @ q0)` | Equivalent to `Terraria.Projectile.Kill()`. |
| `0x001c62a0` | `void ClearProjectile(Projectile* projectile)` | Clears some projectiles properties. |
| `0x001d802c` | `void WavFileName(int32_t* arg1, String* str)` | Converts `str` to be a `.wav` file name. |
| `0x001ef508` | `String* GetIconName(String* name, u32 iconType)` | Gets a terraria icon name with a given `iconType`. |
| `0x00220b5c` | `s32 QuestFishTypeToId(u32 questID)` | Returns the quest fish item id relating to the given `questID`. |
| `0x00237b3c` | `void LoadSound(SoundEffect* sound, String* str, int32_t arg3)` | Loads a sound. |
| `0x00237c50` | `void LoadSound2(SoundEffect* sound, String* str, int32_t arg3)` | Loads a sound. |
| `0x00237d6c` | `void ClearSoundEffect(SoundEffect* sound)` |
| `0x002588ec` | `void ReleaseNPC(s32 X, s32 Y, s32 npcId, u32 style, s32 who)` | Equivalent to `Terraria.NPC.ReleaseNPC()`. |
| `0x0025c97c` | `u32 SpawnCritter(int32_t* arg1)` |
| `0x0027a0cc` | `void KillFrostLegionEnemy(int32_t arg1, NPC* npc)` |
| `0x002945e0` | `String* ForamtString(String* destStr, char* formatStr, void* args)` |
| `0x002946cc` | `String* LoadString(String* arg1, String* dest, char* raw)` |
| `0x0029d5d4` | `void HelpText(PlayerParentPlaceholder* arg1)` | Somewhat equivalent to `Terraria.Main.HelpText()`. |
| `0x0029f858` | `s32 TownNPCFromId(void* arg1, s32 npcId)` | Gets a town NPC id from the given `npcId` |
| `0x002b084c` | `void _cfguExit2(int32_t arg1)` | Exist out of the `cfg:u` service. |
| `0x002b2148` | `int32_t _cfguExit()` | Exist out of the `cfg:u` service. |
| `0x002fb5e0` | `u32 StringLength(char* raw)` |
| `0x002fb9a8` | `String* SetStringTypeString(String* strType, char* rawStr)` |
| `0x002fba24` | `String* FreeStringType4_2(String* str)` |
| `0x002fba2c` | `String* FreeStringType4(String* str)` |
| `0x002fbfa6` | `char* Memcpy_aligned2(char* dest, char* src, u32 length, void* arg4)` |
| `0x002fd91c` | `void Memcpy_aligned(char* dest, char* src, u32 length, void* arg4, void* arg5 @ r12)` |
| `0x002fd9bc` | `void* FreeString3_2(String* str)` |
| `0x002fd9c4` | `void* FreeStringType3(String* str)` |
| `0x00300b0c` | `bool CheckOnce(bool* flag)` | Returns `true` if `flag` was `false` then sets `flag` to `true`, otherwise (if `flag` is `true`) returns `false`. |
| `0x0032ed58` | `u32 SpawnBunny(s32 X, s32 Y)` | Spawn a bunny and does checks for seasons and stuff. |
| `0x00334c78` | `s32 NPCToBanner(s32 npcId)` | Equivalent to `Terraria.Item.NPCtoBanner()`. |
| `0x00336c38` | `int32_t SetDefaults_NPC(NPC* npc, u16 npcId @ r11, int32_t arg3, int32_t arg4)` | Equivalent to `Terraria.NPC.SetDefaults(int, float)`. |
| `0x00342084` | `uint16_t SetDefaultName_NPC(void* npc, String* npcName)` | Equivalent to `Terraria.NPC.SetDefaults(string)`. |
| `0x0034cdb4` | `u32 SpawnSnowmanEnemy(int32_t arg1 @ r4, int32_t arg2 @ r8)` | Spawn a snowman from the Frost Legion. |
| `0x0034ce3c` | `u32 SpawnLiquidNPC(int32_t* arg1)` | 
| `0x0034e39c` | `s32 GetNPCIndex(s32 npcId)` | 
| `0x0034e728` | `u32 CountNPCs2(u32 npcId)` | 
| `0x0034e72c` | `u32 CountNPCs(u32 npcId)` | Equivalent to `Terraria.NPC.CountNPCS()`. |
| `0x0037d7b8` | `u32 NewNPC(s32 X, s32 Y, s32 npcId, int32_t arg4, int32_t arg5 @ r4)` | Equivalent to `Terraria.NPC.NewNPC()`. |
| `0x0038130c` | `bool AnyNPCs(u32 npcId)` | Equivalent to `Terraria.NPC.AnyNPCs()`. |
| `0x00387d4c` | `void NPCLoot(NPC* npc)` | Equivalent to `Terraria.NPC.NPCLoot()`. |
| `0x00393b48` | `void SpawnWOF(Vector2 pos)` | Equivalent to `Terraria.NPC.SpawnWOF()`. |
| `0x003ac694` | `int32_t SetDefaultName_Item(Item* arg1, String* itemName @ r9)` | Equivalent to `Terraria.Item.SetDefaults(string)`. |
| `0x003adfdc` | `void SetDefault_Item(Item* arg1, u32 id, u32 stack)` | Equivalent to `Terraria.Item.SetDefaults(int, ...)`. |
| `0x003c5c20` | `void NetDefaults_Item(Item* item, s32 id, u32 stack)` | Equivalent to `Terraria.Item.netDefaults()`. |
| `0x003c76f4` | `u32 MergeItems(Item* item1, Item* item2)` | Merges 2 items into a single stack. |
| `0x003c77c0` | `bool Prefix_Item(Item* item, s32 prefix, int128_t arg3 @ q4)` | Equivalent to `Terraria.Item.Prefix()`. |
| `0x003c9674` | `u32 NewItem_Item(u32 X, u32 Y, s32 width, s32 height, u32 id, u32 stack, int32_t arg7, s32 prefix, int32_t arg9)` | Equivalent to `Terraria.Item.NewItem()`. |
| `0x003c9e2c` | `u32 GetValueSell(u32 platinum, u32 gold, u32 silver, u32 copper)` | Equivalent to `Terraria.Item.sellPrice()`. |
| `0x003ca190` | `u32 GetValueBuy(u32 platinum, u32 gold, u32 silver, u32 copper)` | Equivalent to `Terraria.Item.buyPrice()`. |
| `0x003d339c` | `uint32_t DoCommand(String* command @ r7)` | Seems to be a place for debug commands, i think its inaccessible though. |
| `0x003d9304` | `int32_t LoadContent(int32_t arg1 @ r4)` | Somewhat equivalent to `Terraria.Main.LoadContent()`, but only for audio. |
| `0x003dbfb4` | `void PlaySoundAt(u32 type, u32 X, u32 Y, u32 style)` | Equivalent to `Terraria.Main.PlaySound()`. |
| `0x003e8874` | `bool IsEaster()` | 
| `0x003e9084` | `bool IsHalloween()` | 
| `0x003e90c8` | `bool IsValentinesDay()` | 
| `0x003e93cc` | `bool IsOktoberfest()` | 
| `0x003e9410` | `bool IsThanksgiving()` | 
| `0x003e9780` | `bool IsChristmas()` | 
| `0x003f6bd0` | `uint32_t SetupShop(Chest* inv, u32 npcType, Player* player)` | Equivalent to `Terraria.Chest.SetupShop()`. |
| `0x003f9040` | `void ClearChest(Chest* chest)` | Clears data of a chest. |
| `0x00447bdc` | `void SetupRecipes()` | Equivalent to `Terraria.Recipe.SetupRecipes()`. |
| `0x0045305c` | `void SetupRecipes2(Item* arg1 @ r5, Item* arg2 @ r6, Item* arg3 @ r7, char* arg4 @ r10)` | Section 2 of `SetupRecipes`. |
| `0x00459044` | `void SetupRecipes3(void* arg1 @ r4, Item* arg2 @ r5, Item* arg3 @ r6, Item* arg4 @ r7, char* arg5 @ r8, int16_t arg6 @ r9, int32_t arg7 @ r10, int32_t arg8, int32_t arg9, int32_t arg10, int32_t arg11, int32_t arg12, int32_t arg13, int32_t arg14, int32_t arg15, int32_t arg16)` | Section 3 of `SetupRecipes`. |
| `0x0045a148` | `void AddRecipe(void* arg1, void* arg2, void* arg3, void* arg4)` | Somewhat equivalent to `Terraria.Recipe.addRecipe()`, but different. |
| `0x00464fb4` | `void SetNpcCatchable()` | Sets the array of catchable NPCs. |
| `0x0046cf94` | `int32_t GetAnglerReward(Player* player)` | Gets the angler reword. |
| `0x0046e830` | `u32 GetQuestFishId()` | Calls `s32 QuestFishTypeToId(u32 questID)` on the current quest fish. |
| `0x00470090` | `void LoadWorldFileHeader2(FileReader* reader, int32_t arg2)` |
| `0x0048e030` | `int32_t* DrawItemSlot(Draw_Unk2* arg1, int32_t* arg2, s32 num1, String* str1, int32_t arg5)` |
| `0x004a17a4` | `void ClearWorld()` | Seems to clear world data. |
| `0x004a9b1c` | `void GorwPumpkin(u32 X, u32 Y, s32 id)` | Equivalent to `Terraria.WorldGen.GrowPumpkin()`. |
| `0x004b75e0` | `void PlacePumpkin(u32 X, u32 Y)` | Equivalent to `Terraria.WorldGen.PlacePumpkin()`. |
| `0x004bc550` | `int32_t GenerateWorld()` | 
| `0x004cb5dc` | `void LoadWorldFileHeader(FileReader* reader, int32_t arg2)` | 
| `0x004d529c` | `void LoadWorldFileHeader2(FileReader* reader, int32_t arg2)` | 
| `0x004da27c` | `void RandomBackgrounds()` | 
| `0x004fe1e8` | `void LoadWorld(FileReader* reader)` | 
| `0x00524c4c` | `s32 ShopItemSlotCount()` | Returns the number of slots in a store. (ItemCount + 5) |
| `0x005252ec` | `bool StringCompare(String* str1, char* rawString)` | 
| `0x00532a94` | `bool PlayerHasQuestFish(int32_t arg1, Player* arg2)` | Calls `PlayerHasItem()` with `GetQuestFishId()`. |
| `0x00532ab0` | `bool PlayerHasItem(Player* player, u32 itemId)` | Returns if `player` has an item with a given `itemId`. |
| `0x00553ae8` | `uint32_t ClearAll()` | Clears a bunch of stuff like, audio, Chests, Items and more. |
| `0x005a3cc8` | `ImageLoader* GetImageLoader()` | Returns `&imageLoader`, may also call `ClearImageLoader()`. |

# Variables

| Address      | Variables | Description
| ------------ | --------- | - |
| `0x00631a6c` | `u8 questFishType` |  |
| `0x00631c98` | `float cloudBGActive` |  |
| `0x006329a4` | `bool planteraDown` |  |
| `0x0063302e` | `u8 mouseTextColor` |  |
| `0x00633114` | `World worldData` |  |
| `0x00633121` | `bool crimsonWorld` |  |
| `0x0063313c` | `u16 copperType` |  |
| `0x0063313e` | `u16 ironType` |  |
| `0x00633140` | `u16 silverType` |  |
| `0x00633142` | `u16 goldType` |  |
| `0x00633148` | `u16 coboltType` |  |
| `0x0063314a` | `u16 mythrilType` |  |
| `0x0063314c` | `u16 adamantiteType` |  |
| `0x0063314e` | `u16 worldWidth` |
| `0x00633150` | `u16 worldHeight` |
| `0x0063339e` | `bool isHardmode` |
| `0x00634bcc` | `u32 cfgu_RefCount` |
| `0x00634c54` | `char const (* gspGpu_Ref)[0x9] = data_5ded9f {"gsp::Gpu"}` |
| `0x00634c58` | `char const (* data_634c58)[0x9] = data_5ded96 {"gsp::Lcd"}` |
| `0x007b9f64` | `void* BackgroundPointers[0xA]` |
| `0x007b9f8c` | `bool NPC_catchable[0x406]` |
| `0x007bc164` | `int128_t randomNumSeed` |
| `0x007c42e0` | `Recipe newRecipe` |
| `0x0085569c` | `int32_t genRandomSeed1` |
| `0x00855c14` | `Chest townNpcInvs[0x12]` |
| `0x0086cfe4` | `Item itemArr_1[0x5]` |
| `0x0086d278` | `Draw_Unk3 drawer_1` |
| `0x0088d394` | `int32_t randomNumSeed2` |
| `0x0088d3c0` | `SoundEffect soundMech` | Equivalent to `Terraria.Main.soundMech[0]`. |
| `0x0088d3dc` | `SoundEffect soundDig_1` | Equivalent to `Terraria.Main.soundDig[0]`. |
| `0x0088d3f8` | `SoundEffect soundDig_2` | Equivalent to `Terraria.Main.soundDig[1]`. |
| `0x0088d414` | `SoundEffect soundDig_3` | Equivalent to `Terraria.Main.soundDig[2]`. |
| `0x0088d430` | `SoundEffect soundTink_1` | Equivalent to `Terraria.Main.soundTink[0]`. |
| `0x0088d44c` | `SoundEffect soundTink_2` | Equivalent to `Terraria.Main.soundTink[1]`. |
| `0x0088d468` | `SoundEffect soundTink_3` | Equivalent to `Terraria.Main.soundTink[2]`. |
| `0x0088d484` | `SoundEffect soundPlayerHit_1` | Equivalent to `Terraria.Main.soundPlayerHit[0]`. |
| `0x0088d4a0` | `SoundEffect soundPlayerHit_2` | Equivalent to `Terraria.Main.soundPlayerHit[1]`. |
| `0x0088d4bc` | `SoundEffect soundPlayerHit_3` | Equivalent to `Terraria.Main.soundPlayerHit[2]`. |
| `0x0088d4d8` | `SoundEffect soundPlayerHitFemail_1` | Equivalent to `Terraria.Main.soundPlayerHitFemail[0]`. |
| `0x0088d4f4` | `SoundEffect soundPlayerHitFemail_2` | Equivalent to `Terraria.Main.soundPlayerHitFemail[1]`. |
| `0x0088d510` | `SoundEffect soundPlayerHitFemail_3` | Equivalent to `Terraria.Main.soundPlayerHitFemail[2]`. |
| `0x0088d52c` | `SoundEffect soundPlayerKilled` | Equivalent to `Terraria.Main.soundPlayerKilled`. |
| `0x0088d548` | `SoundEffect soundGrass` | Equivalent to `Terraria.Main.soundGrass`. |
| `0x0088d564` | `SoundEffect soundGrab` | Equivalent to `Terraria.Main.soundGrab`. |
| `0x0088d580` | `SoundEffect soundPixie` | Equivalent to `Terraria.Main.soundPixie`. |
| `0x0088d59c` | `SoundEffect soundItem[0x38]` | Equivalent to `Terraria.Main.soundItem[]`. |
| `0x0088dbbc` | `SoundEffect soundNPCHit[0xe]` | Equivalent to `Terraria.Main.soundNPCHit[]`. |
| `0x0088dd44` | `SoundEffect soundNPCKilled[0x14]` | Equivalent to `Terraria.Main.soundNPCKilled[]`. |
| `0x0088df74` | `SoundEffect soundDoorOpen` | Equivalent to `Terraria.Main.soundDoorOpen`. |
| `0x0088df90` | `SoundEffect soundDoorClose` | Equivalent to `Terraria.Main.soundDoorClose`. |
| `0x0088e01c` | `SoundEffect soundZombie[0x15]` | Equivalent to `Terraria.Main.soundZombie[]`. |
| `0x0088e348` | `SoundEffect soundChat` | Equivalent to `Terraria.Main.soundChat`. |
| `0x0088e850` | `Item item_Main[0xc9]` | Equivalent to `Terraria.Main.item[]`. |
| `0x00894ff4` | `Projectile projectile_Main[0x200]` | Equivalent to `Terraria.Main.projectile[]`. |
| `0x008d4ef8` | `ImageLoader imageLoader` | 
| `0x082a9ac4` | `NPC NPC_Main[0xc3]` | Equivalent to `Terraria.Main.npc[]`. |
| `0x083a9238` | `Item recipeItems1[0x6]` | 
| `0x300037c4` | `Tile Tile_Main[0x180858]` | Equivalent to `Terraria.Main.tile[]`. (size may be different on old and new 3DSs) |

# 3ModLoader
3ModLoader is a mod loader for this versions of 3DS Terraria, build off of a modified versions of Luma3DS (specifically the Rosalina sysmodule) called "cMod" (which is the name at the moment, but i want to change it).
'cMod' has a built in ram viewer and reader, memory dumper, debugger, file viewer (with a custom ftp like file server), UI system, plugin system and more.
3Modloader itself is a plugin to 'cMod' that currently just has built in mods and hacks, it cant actually load mods.
But its not public yet since its very finicky and not user friendly.
However i (crawdad105) may release a modified boot.firm, with the 3ModLoader plugin but for now im not.
