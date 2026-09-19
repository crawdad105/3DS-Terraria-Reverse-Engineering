| Address | Variables | Description |
| - | - | - |
| `0x00246038` | `char en_str[0x3]` |  |
| `0x005d6218` | `State_VTable CreditsMenu_State_vtable` |  |
| `0x005d6254` | `BaseMenu_VTable CreditsMenu_Menu_vtable` |  |
| `0x005d6390` | `void* FullVersion_vtable` |  |
| `0x005d64bc` | `State_VTable ExtractState_vtable` |  |
| `0x005d64f4` | `SpriteBatch_VTable SpriteBatch_vtable` |  |
| `0x005d6640` | `BaseDrawable_VTable BaseDrawable_vtable` |  |
| `0x005d683c` | `void* OptionsMenuBottom_State_vtable` |  |
| `0x005d6998` | `StateManager_VTable StateManager_vtable_1` |  |
| `0x005d6a68` | `TextureAtlas_VTable TextureAtlas_vtable` |  |
| `0x005d6e54` | `MiniMapHelper_VTable MiniMapHelper_vtable` |  |
| `0x005d6e98` | `TerrariaAtlas_VTable TerrariaAtlas_vtable` |  |
| `0x005d7168` | `State_VTable MenuBackground_State_vtable` |  |
| `0x005d71a0` | `BaseMenu_VTable MenuBackground_Menu_vtable` |  |
| `0x005d78b8` | `GameStateManager_VTable GameStateManager_vtable_2` |  |
| `0x005d7968` | `State_VTable OptionsMenu_State_vtable` |  |
| `0x005d79a4` | `BaseMenu_VTable OptionsMenu_Menu_vtable` |  |
| `0x005d8a80` | `State_VTable State_vtable` |  |
| `0x005d8bc8` | `BaseDrawable_VTable Sprite_vtable` |  |
| `0x005d8d6c` | `BaseMenu_VTable BaseMenu_Menu_vtable` |  |
| `0x005d8ef4` | `State_VTable MainMenu_State_vtable` |  |
| `0x005d8f2c` | `BaseMenu_VTable MainMenu_Menu_vtable` |  |
| `0x005d9058` | `GameState_VTable GameState_vtable` |  |
| `0x005d90a0` | `State_VTable BaseMenuState_State_vtable_2` |  |
| `0x005d90d8` | `BaseMenu_VTable BaseMenuState_Menu_vtable_2` |  |
| `0x005d91dc` | `Texture_VTable Texture_vtable` |  |
| `0x005d948c` | `void* StateManager_vtable_2` |  |
| `0x0063165c` | `u32 NPC::fireFlyFriendly` |  |
| `0x00631660` | `u32 NPC::fireFlyChance` |  |
| `0x00631664` | `u32 NPC::fireFlyMultiple` |  |
| `0x00631668` | `u32 NPC::butterflyChance` |  |
| `0x00631a6c` | `u8 questFishType` |  |
| `0x00631c18` | `int32_t Underground::magmaBGFrame` |  |
| `0x00631c98` | `float cloudBGActive` |  |
| `0x00631dbc` | `Main* GameState::Terraria` |  |
| `0x00631dc0` | `void* GameState::terrariaLoader` |  |
| `0x00631fa4` | `char Collision::honey` |  |
| `0x00631fc4` | `Colour Color::White` |  |
| `0x00631fec` | `Colour Color::Red` |  |
| `0x0063213c` | `int32_t Gamer::localSignedInGamer` |  |
| `0x006321d0` | `int32_t Item::lastItemIndex` |  |
| `0x00632754` | `void* Lang::setLanguage` |  |
| `0x006327f6` | `char Liquid::quickSettle` |  |
| `0x00632804` | `int32_t Liquid::cycles` |  |
| `0x0063286e` | `int16_t MiniMap::width` |  |
| `0x00632870` | `int16_t MiniMap::height` |  |
| `0x00632872` | `int16_t MiniMap::texWidth` |  |
| `0x00632874` | `int16_t MiniMap::texHeight` |  |
| `0x00632878` | `int32_t MiniMap::maxScaleLimit` |  |
| `0x0063287c` | `int32_t MiniMap::minScaleLimit` |  |
| `0x00632880` | `int32_t MiniMap::exportedMapCount` |  |
| `0x006328c4` | `int32_t NetMessage::MessagesSendSince` |  |
| `0x006328c8` | `int32_t NetMessage::TotalMessageSizeSince` |  |
| `0x006328ec` | `char Netplay::disconnect` |  |
| `0x006328ed` | `char Netplay::stopSession` |  |
| `0x006328f0` | `char Netplay::mode` |  |
| `0x006328f4` | `int32_t Netplay::gamer` |  |
| `0x00632900` | `int32_t Netplay::session` |  |
| `0x0063292c` | `char Netplay::IsAboutToJoinASession` |  |
| `0x0063299a` | `bool NPC::downedGoblins` |  |
| `0x0063299d` | `bool NPC::downedRabbit` |  |
| `0x006329a4` | `bool planteraDown` |  |
| `0x006329b4` | `int32_t NPC::wof` |  |
| `0x006329b8` | `int32_t NPC::golemBoss` |  |
| `0x006329bc` | `int32_t NPC::plantBoss` |  |
| `0x006329c0` | `int32_t NPC::crimsonBoss` |  |
| `0x00632e3c` | `Texture* color_swatch_Texture` |  |
| `0x0063302e` | `u8 mouseTextColor` |  |
| `0x0063303c` | `int32_t UI::cursorScale` | Seem to be unused, only ever set in `UI::UpdateCursorColor`. |
| `0x0063306c` | `Colour UI::WINDOW_OUTLINE` |  |
| `0x00633074` | `void* UI::theGame` | Might be unused, set in `UI::Initialize` |
| `0x00633078` | `Colour UI::mouseTextColor` |  |
| `0x0063307c` | `Colour UI::mouseColor` |  |
| `0x00633080` | `Colour UI::cursorColor` | Seem to be unused, only ever set in `UI::UpdateCursorColor` and `_INIT_140`. |
| `0x00633084` | `Texture* texture_touchzoom` | Supposed to contain "UI/texture_touchzoom.png", but the files does not exist and the variable is only ever set, not used. |
| `0x006330bc` | `bool flag1` | Accessed from `Main::Update` but never set, ram dump shows its `false`, it is is `true` the user seems to gets disconnected. |
| `0x00633114` | `char WorldGen::tEvil` |  |
| `0x00633115` | `char WorldGen::tGood` |  |
| `0x00633118` | `char WorldGen::gen` |  |
| `0x0063311a` | `bool WorldGen::shadowOrbSmashed` |  |
| `0x00633120` | `char WorldGen::destroyObject` |  |
| `0x00633121` | `char crimsonWorld` |  |
| `0x00633127` | `bool IsWorldSize_4200` | Seems to check if the world is 4200 blocks wide, this also seems to be 3ds exclusive. |
| `0x0063313c` | `int16_t copperType` |  |
| `0x0063313e` | `u16 ironType` |  |
| `0x00633140` | `u16 silverType` |  |
| `0x00633142` | `u16 goldType` |  |
| `0x00633148` | `s16 WorldGen::oreTier1` |  |
| `0x0063314a` | `s16 WorldGen::oreTier2` |  |
| `0x0063314c` | `u16 WorldGen::oreTier3` |  |
| `0x0063314e` | `u16 worldWidth_2` |  |
| `0x00633150` | `u16 worldHeight_2` |  |
| `0x00633160` | `u32 WorldGen::treeBG` |  |
| `0x0063316c` | `u32 WorldGen::snowBG` |  |
| `0x0063324c` | `int32_t WorldGen::waterLine` |  |
| `0x006332ed` | `char Main::isLocalWorld` |  |
| `0x00633390` | `bool Main::FirstFrame` |  |
| `0x0063339c` | `char Main::isGameStarted` |  |
| `0x0063339d` | `char Main::isGamePaused` |  |
| `0x0063339e` | `bool Main::hardMode` |  |
| `0x006333a0` | `bool Main::isHDTV` | Seems to go unused |
| `0x006333a6` | `u16 Main::maxTilesX` |  |
| `0x006333a8` | `int16_t Main::maxTilesY` |  |
| `0x006333ac` | `int32_t Main::screenWidth` |  |
| `0x006333b0` | `int32_t Main::screenHeight` |  |
| `0x006333b8` | `int32_t Main::SheetSpritesOffset` | No variable reference. Only set in `Main::Main` it seems. |
| `0x006333e0` | `int32_t Main::frameCounter` |  |
| `0x006333f4` | `int32_t Main::SpaceLevel` |  |
| `0x006333f8` | `u32 Main::worldSurface` | *Verify |
| `0x00633408` | `u32 Main::MainPlayerIndex` | Equivalent to `myPlayer` |
| `0x00633430` | `void* Main::AchievementSystem` |  |
| `0x00633440` | `int32_t Main::worldSurfacePixels` |  |
| `0x00633495` | `bool Main::DoneLoading` |  |
| `0x00633b3c` | `int32_t SpriteBatch::globalSpriteBatch` |  |
| `0x00633f68` | `Vector2 WidgetLoader::WidgetScale` |  |
| `0x00634bcc` | `u32 cfgu_RefCount` |  |
| `0x007b9f64` | `Texture* BackgroundPointers[0xa]` |  |
| `0x007b9f8c` | `bool NPC_catchable[0x406]` |  |
| `0x007ba75c` | `void* Underground::backgroundTexture` |  |
| `0x007bc164` | `int128_t randomNumSeed` | Named g_rand on mobile. |
| `0x007bc1d8` | `void* Gore::gore` |  |
| `0x007c17d4` | `void* NetMessage::packetOut` |  |
| `0x007c1890` | `int32_t Netplay::gamersWaitingForPlayerId` |  |
| `0x007c18ec` | `NPC* NPC::npc` |  |
| `0x007c42e0` | `Recipe Recipe::newRecipe` |  |
| `0x007c4b20` | `Tile* Tile::tile` |  |
| `0x0085569c` | `int128_t WorldGen::genRand` |  |
| `0x00855c14` | `Chest townNpcInvs[0x12]` |  |
| `0x0086cfe4` | `Item itemArr_1[0x5]` |  |
| `0x0086d278` | `XNASpriteBatch XNASpriteBatch::Instance` | Seems to contain a vertex buffer.,Similar to `SpriteBatch::globalSpriteBatch`. |
| `0x0088d2dc` | `Colour Main::teamColor` |  |
| `0x0088d394` | `int128_t Main::rand` |  |
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
| `0x0088dfac` | `SoundEffect soundMenuOpen` |  |
| `0x0088dfc8` | `SoundEffect soundMenuClose` |  |
| `0x0088dfe4` | `SoundEffect soundMenuTick` |  |
| `0x0088e000` | `SoundEffect soundShatter` |  |
| `0x0088e01c` | `SoundEffect soundZombie[0x15]` | Equivalent to `Terraria.Main.soundZombie[]`. |
| `0x0088e268` | `SoundEffect soundRoar_1` |  |
| `0x0088e284` | `SoundEffect soundRoar_2` |  |
| `0x0088e2a0` | `SoundEffect soundSplash_1` |  |
| `0x0088e2bc` | `SoundEffect soundSplash_2` |  |
| `0x0088e2d8` | `SoundEffect soundDoubleJump` |  |
| `0x0088e2f4` | `SoundEffect soundRun` |  |
| `0x0088e310` | `SoundEffect soundCoins` |  |
| `0x0088e32c` | `SoundEffect soundUnlock` |  |
| `0x0088e348` | `SoundEffect soundChat` | Equivalent to `Terraria.Main.soundChat`. |
| `0x0088e364` | `SoundEffect soundMaxMana` |  |
| `0x0088e380` | `SoundEffect soundDrown` |  |
| `0x0088e770` | `void* Main::musicFade` | Equivalent to `Terraria.Main.musicFade[]`. |
| `0x0088e850` | `Item item_Main[0xc9]` | Equivalent to `Terraria.Main.item[]`. |
| `0x00894ff4` | `Projectile projectile_Main[0x200]` | Equivalent to `Terraria.Main.projectile[]`. |
| `0x008b4080` | `Player* player[0x4]` |  |
| `0x008d4b38` | `TextureAtlas UIAtlas::Instance` |  |
| `0x008d4bdc` | `CameraZoomer CameraZoomer::Instance` |  |
| `0x008d4ef8` | `ContentLoader ContentLoader::Instance` |  |
| `0x008d5024` | `TerrariaAtlas TerrariaAtlas::Instance` |  |
| `0x008d5108` | `GraphicsDevice GraphicsDevice::Instance` | *Verify, manually inferred. |
| `0x008d52ac` | `GameStateManager GameStateManager::Instance` |  |
| `0x008d55e4` | `UI ui` |  |
| `0x008d83a0` | `MiniMap* MiniMap::Instance` |  |
| `0x008d98b8` | `void* WorldView::Instance` |  |
| `0x008dae70` | `u32 Main::quickBG` | Matches `Main.quickBG`, does not have a name on mobile. Also does not seem to be used, its only set to `10`/`0x0A`. |
| `0x083a9238` | `Item recipeItems1[0x6]` |  |
| `0x090a2c08` | `Player _player1` |  |
| `0x300037c4` | `Tile Tile_Main[0x180858]` | Equivalent to `Terraria.Main.tile[]`. (Size may be different on old and new 3DSs) |
