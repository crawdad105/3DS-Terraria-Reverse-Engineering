| Address | Function Signature | Description |
| - | - | - |
| `0x001006de` | `void* ForEach(void* elms, u32 count, u32 elmSize, void (__convention("cdecl")* foo)(void*))` | Runs `foo` for every element in `elms`. |
| `0x00101042` | `u32 Utf16_strlen(u16* utf16_str)` | `strlen()` for a utf16 string.,`strcmp()` for a utf16 string.,Inits the 3DSs `cfg:u` service. |
| `0x00101b5c` | `u32 Utf16_strcmp(u16* str1, u16* str2, u32 length)` |  |
| `0x00113ce4` | `int32_t _cfguInit()` |  |
| `0x00115198` | `void CreateColour(Colour* c, u32 R, u32 G, u32 B, u32 A)` | Creates a colour struct. |
| `0x0011ec7c` | `void ClearItem2(Item* item)` | Clears some item properties. |
| `0x00137c24` | `void ShowPopup(String* string)` |  |
| `0x0013b8cc` | `void ClearItem(Item* item)` | Clears some item properties. |
| `0x0013bac4` | `void Main::PlaySound(s32 soundId)` | Plays a sound with a given id. |
| `0x0013f940` | `int32_t RandomNumber(int32_t* arg1, int32_t arg2)` | In place of FastRandom::Next() from mobile it seems. |
| `0x0013f9b4` | `s32 RandomNumberRange(int128_t* seed, s32 min, s32 max)` |  |
| `0x00143ef4` | `Player* GetPlayer()` |  |
| `0x0014a24c` | `ImageLoader* ClearImageLoader(ImageLoader* arg1)` | Clears some data relating to what seems to be an image loader. |
| `0x0014b3e0` | `int32_t EE::String::Null(void** arg1)` |  |
| `0x0014b594` | `void EE::String::~String(String* str)` |  |
| `0x0014b5bc` | `String* EE::String::operator=(String* str, String* arg2, void* arg3)` |  |
| `0x0014f7b8` | `void* FreeStringType2(String* str)` |  |
| `0x00152090` | `String* EE::String::String(String* str1, char* rawStr)` |  |
| `0x0015d71c` | `u32 MurmurHash3(String* string, u32 seed)` |  |
| `0x0015dcf4` | `int32_t GlyphSet::GetGlyph(void* arg1, int32_t arg2)` |  |
| `0x0017e3f4` | `void LoadBackground()` | Loads Terraria's background images. |
| `0x00180054` | `void DrawBackground(void* arg1, u32 backgroundType, int32_t arg3, Colour colour1 @ r9, int32_t arg5 @ r11, int32_t arg6, int32_t arg7)` | Draws a background. |
| `0x001ab3a0` | `uint32_t Projectile::Kill(Projectile* projectile, int128_t arg2 @ q0)` | Equivalent to `Terraria.Projectile.Kill()`. |
| `0x001c62a0` | `void ClearProjectile(Projectile* projectile)` | Clears some projectiles properties. |
| `0x001d802c` | `void SoundEffect::Load(int32_t* arg1, String* str)` | Converts `str` to be a `.wav` file name. |
| `0x001dc890` | `void* Underground::LoadContent()` |  |
| `0x001e3624` | `void Achievements::TriggerSystem::ReadProfile(int32_t arg1, int32_t arg2)` |  |
| `0x001e366c` | `void* Achievements::TriggerSystem::UpdateAchievements(void* arg1)` |  |
| `0x001e3b28` | `uint32_t Achievements::AchievementSystem::Award(char* arg1, uint32_t arg2)` |  |
| `0x001ef508` | `String* GetIconName(String* name, u32 iconType)` | Gets a terraria icon name with a given `iconType`. |
| `0x001fc97c` | `int32_t* WidgetLoader::loadSprite(void* arg1)` |  |
| `0x001fccc8` | `void*** WidgetLoader::loadWidget(void* arg1, int32_t arg2 @ r5)` |  |
| `0x002021f8` | `int32_t WidgetLoader::load(int32_t* arg1, void* arg2 @ r4, int32_t arg3 @ r5)` |  |
| `0x00220b5c` | `s32 QuestFishTypeToId(u32 questID)` | Returns the quest fish item id relating to the given `questID`. |
| `0x00237b3c` | `void LoadSound(SoundEffect* sound, String* str, int32_t arg3)` | Loads a sound. |
| `0x00237c50` | `void LoadSound2(SoundEffect* sound, String* str, int32_t arg3)` | Loads a sound. |
| `0x00237d6c` | `void ClearSoundEffect(SoundEffect* sound)` |  |
| `0x002588ec` | `void ReleaseNPC(s32 X, s32 Y, s32 npcId, u32 style, s32 who)` | Equivalent to `Terraria.NPC.ReleaseNPC()`. |
| `0x0025c97c` | `u32 NPC::SpawnFriendlyNPC(int32_t* arg1)` |  |
| `0x0025cfa0` | `void setFireFlyChance()` |  |
| `0x0027a0cc` | `void KillFrostLegionEnemy(int32_t arg1, NPC* npc)` |  |
| `0x002945e0` | `String* EE::String::Format(String* destStr, char* formatStr, void* args)` |  |
| `0x002946cc` | `String* LoadString(String* arg1, String* dest, char* raw)` |  |
| `0x002980e0` | `int32_t UI::UpdateNpcChat(PlayerParentPlaceholder* arg1, int32_t arg2 @ r4)` |  |
| `0x0029d5d4` | `void UI::HelpText(PlayerParentPlaceholder* arg1)` | Somewhat equivalent to `Terraria.Main.HelpText()`. |
| `0x0029f858` | `s32 TownNPCFromId(void* arg1, s32 npcId)` | Gets a town NPC id from the given `npcId` |
| `0x002b084c` | `void _cfguExit2(int32_t arg1)` | Exist out of the `cfg:u` service. |
| `0x002b2148` | `int32_t _cfguExit()` | Exist out of the `cfg:u` service. |
| `0x002fb5e0` | `u32 StringLength(char* raw)` |  |
| `0x002fb9a8` | `String* SetStringTypeString(String* strType, char* rawStr)` |  |
| `0x002fba24` | `String* FreeStringType4_2(String* str)` |  |
| `0x002fba2c` | `String* FreeStringType4(String* str)` |  |
| `0x002fbfa6` | `char* Memcpy_aligned2(char* dest, char* src, u32 length, void* arg4)` |  |
| `0x002fd91c` | `void Memcpy_aligned(char* dest, char* src, u32 length, void* arg4, void* arg5 @ r12)` |  |
| `0x002fd9bc` | `void* FreeString3_2(String* str)` |  |
| `0x002fd9c4` | `void* FreeStringType3(String* str)` |  |
| `0x00300b0c` | `bool CheckOnce(bool* flag)` | Returns `true` if `flag` was `false` then sets `flag` to `true`, otherwise (if `flag` is `true`) returns `false`. |
| `0x0032aaa8` | `int32_t Cue::Load(void* arg1, int32_t* arg2)` |  |
| `0x0032b0d0` | `int32_t Cue::IsPlaying(void* arg1)` |  |
| `0x0032ed58` | `u32 NPC::SpawnBunny(s32 X, s32 Y)` | Spawn a bunny and does checks for seasons and stuff. |
| `0x00334c78` | `s32 NPCToBanner(s32 npcId)` | Equivalent to `Terraria.Item.NPCtoBanner()`. |
| `0x00336c38` | `int32_t SetDefaults_NPC(NPC* npc, u16 npcId @ r11, int32_t arg3, int32_t arg4)` | Equivalent to `Terraria.NPC.SetDefaults(int, float)`. |
| `0x00342084` | `uint16_t SetDefaultName_NPC(void* npc, String* npcName)` | Equivalent to `Terraria.NPC.SetDefaults(string)`. |
| `0x0034cdb4` | `u32 SpawnSnowmanEnemy(int32_t arg1 @ r4, int32_t arg2 @ r8)` | Spawn a snowman from the Frost Legion. |
| `0x0034ce3c` | `u32 SpawnLiquidNPC(int32_t* arg1)` |  |
| `0x0034e39c` | `s32 GetNPCIndex(s32 npcId)` |  |
| `0x0034e728` | `u32 CountNPCs2(u32 npcId)` |  |
| `0x0034e72c` | `u32 NPC::AnyNPCs(u32 npcId)` | Equivalent to `Terraria.NPC.CountNPCS()`. |
| `0x00350490` | `u32 NPC::SpawnUniqueNPC(int32_t* arg1, int32_t arg2 @ r4, int32_t arg3 @ r5)` |  |
| `0x00372c1c` | `u32 NPC::SpawnPositionBasedNPC(int32_t* arg1)` |  |
| `0x0037d7b8` | `u32 NPC::NewNPC(s32 X, s32 Y, s32 npcId, int32_t arg4, int32_t arg5 @ r4)` | Equivalent to `Terraria.NPC.NewNPC()`. |
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
| `0x003d25e4` | `int32_t Main::LoadContent(void* arg1)` |  |
| `0x003d339c` | `uint32_t DoCommand(String* command @ r7)` | Seems to be a place for debug commands, i think its inaccessible though. |
| `0x003d9304` | `void Main::LoadingThread(void* mainInstance)` | Somewhat equivalent to `Terraria.Main.LoadContent()`, but only for audio. |
| `0x003dbf10` | `int32_t Main::PlayMusic(int32_t arg1, int32_t arg2)` |  |
| `0x003dbfb4` | `void Main::PlaySound_At(u32 type, u32 X, u32 Y, u32 style)` | Equivalent to `Terraria.Main.PlaySound()`. |
| `0x003dce64` | `void** Main::Main(void** arg1)` |  |
| `0x003e8874` | `bool Time::IsEaster()` | Doesn't seem to match mobile. |
| `0x003e9084` | `bool Time::IsHalloween()` | Doesn't seem to match mobile. |
| `0x003e90c8` | `bool IsValentinesDay()` |  |
| `0x003e93cc` | `bool IsOktoberfest()` |  |
| `0x003e9410` | `bool IsThanksgiving()` |  |
| `0x003e9780` | `bool Time::IsChristmas()` | Doesn't seem to match mobile. |
| `0x003f6bd0` | `uint32_t SetupShop(Chest* inv, u32 npcType, Player* player)` | Equivalent to `Terraria.Chest.SetupShop()`. |
| `0x003f9040` | `void ClearChest(Chest* chest)` | Clears data of a chest. |
| `0x003ff494` | `int32_t Mount::Initialize()` |  |
| `0x004005e0` | `void Mount::AnimState::AnimState(int32_t* arg1)` |  |
| `0x004005f8` | `int32_t Mount::MountData::MountData(void* arg1)` |  |
| `0x0040be30` | `void UpdatePlayer(Player* player, u32 playerId)` | *Verify |
| `0x00447bdc` | `void SetupRecipes()` | Equivalent to `Terraria.Recipe.SetupRecipes()`. |
| `0x0045305c` | `void SetupRecipes2(Item* arg1 @ r5, Item* arg2 @ r6, Item* arg3 @ r7, char* arg4 @ r10)` | Section 2 of `SetupRecipes`. |
| `0x00459044` | `void SetupRecipes3(void* arg1 @ r4, Item* arg2 @ r5, Item* arg3 @ r6, Item* arg4 @ r7, char* arg5 @ r8, int16_t arg6 @ r9, int32_t arg7 @ r10, int32_t arg8, int32_t arg9, int32_t arg10, int32_t arg11, int32_t arg12, int32_t arg13, int32_t arg14, int32_t arg15, int32_t arg16)` | Section 3 of `SetupRecipes`. |
| `0x0045a148` | `void AddRecipe(void* arg1, void* arg2, void* arg3, void* arg4)` | Somewhat equivalent to `Terraria.Recipe.addRecipe()`, but different. |
| `0x00464fb4` | `void SetNpcCatchable()` | Sets the array of catchable NPCs. |
| `0x0046cf94` | `int32_t GetAnglerReward(Player* player)` | Gets the angler reword. |
| `0x0046e830` | `u32 GetQuestFishId()` | Calls `s32 QuestFishTypeToId(u32 questID)` on the current quest fish. |
| `0x00470090` | `void LoadWorldFileHeader2(FileReader* reader, int32_t arg2)` |  |
| `0x0047a67c` | `int32_t XMLFile::readString(int32_t arg1, void* arg2, int32_t* arg3)` |  |
| `0x0047ace4` | `int32_t XMLFile::getAttribute(int32_t arg1, void* arg2, int32_t* arg3)` | *Verify |
| `0x0047c698` | `int32_t XMLFile::gotoNode(void* arg1, int32_t arg2)` |  |
| `0x0047c714` | `int32_t* XMLFile::hasChild(void* arg1, int32_t* arg2)` |  |
| `0x0047c740` | `int32_t XMLFile::readBool(void* arg1)` |  |
| `0x0047c8d0` | `int32_t XMLFile::gotoChild(void* arg1, int32_t* arg2)` |  |
| `0x0047c940` | `int32_t XMLFile::gotoStart(void* arg1)` |  |
| `0x0048e030` | `int32_t* DrawItemSlot(Draw_Unk2* arg1, int32_t* arg2, s32 num1, String* str1, int32_t arg5)` |  |
| `0x004a17a4` | `void ClearWorld()` | Seems to clear world data. |
| `0x004a9b1c` | `void WorldGen::GrowPumpkin(u32 X, u32 Y, s32 id)` | Equivalent to `Terraria.WorldGen.GrowPumpkin()`. |
| `0x004b75e0` | `void PlacePumpkin(u32 X, u32 Y)` | Equivalent to `Terraria.WorldGen.PlacePumpkin()`. |
| `0x004bc550` | `int32_t GenerateWorld()` |  |
| `0x004cb5dc` | `void LoadWorldFileHeader(FileReader* reader, int32_t arg2)` |  |
| `0x004d529c` | `void LoadWorldFileHeader2(FileReader* reader, int32_t arg2)` |  |
| `0x004da27c` | `void RandomBackgrounds()` |  |
| `0x004fe1e8` | `void LoadWorld(FileReader* reader)` |  |
| `0x0050fc9c` | `void* GameState::GameState(void* arg1)` |  |
| `0x00524c4c` | `s32 ShopItemSlotCount()` | Returns the number of slots in a store. (ItemCount + 5) |
| `0x005252ec` | `bool StringCompare(String* str1, char* rawString)` |  |
| `0x00532a94` | `bool PlayerHasQuestFish(int32_t arg1, Player* arg2)` | Calls `PlayerHasItem()` with `GetQuestFishId()`. |
| `0x00532ab0` | `bool PlayerHasItem(Player* player, u32 itemId)` | Returns if `player` has an item with a given `itemId`. |
| `0x00553ae8` | `uint32_t ClearAll()` | Clears a bunch of stuff like, audio, Chests, Items and more. |
| `0x005a3cc8` | `ImageLoader* GetImageLoader()` | Returns `&imageLoader`, may also call `ClearImageLoader()`. |
