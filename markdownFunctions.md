| Address | Function Signature | Description |
| - | - | - |
| `0x001006de` | `void ForEach(void* elms, u32 count, u32 elmSize, void (__convention("cdecl")* foo)(void*))` | Runs `foo` for every element in `elms`. |
| `0x00101042` | `u32 Utf16_strlen(u16* utf16_str)` | `strlen()` for a utf16 string.,`strcmp()` for a utf16 string.,Inits the 3DSs `cfg:u` service. |
| `0x00101a3e` | `int32_t delete2(int32_t* arg1)` |  |
| `0x00101ae8` | `uint32_t memcmp(int32_t* arg1, char* rawStr, int32_t arg3)` |  |
| `0x00101b5c` | `u32 wmemcmp(u16* str1, u16* str2, u32 length)` |  |
| `0x00102800` | `int32_t* __dynamic_cast(int32_t* arg1, void* arg2, void* arg3)` | *Verify |
| `0x00102a04` | `int32_t printf(int32_t arg1, int16_t* arg2)` |  |
| `0x00102a28` | `int32_t fprintf(int32_t arg1, int32_t arg2, int32_t* arg3 @ r8, char** arg4 @ r9, int32_t arg5 @ pc, int32_t arg6, int32_t arg7, int32_t arg8, int32_t arg9, int32_t arg10, int32_t arg11, int32_t arg12, int32_t arg13, int32_t arg14)` | *Verify |
| `0x00102a28` | `int32_t fprintf(void* arg1, int32_t arg2, int16_t* arg3)` | *Verify |
| `0x00109610` | `int32_t StateManager::AddState(GameStateManager* gsm, String* str, BaseMenuState* menuState)` | Expands the mobile function `std::map<std::string, State*>::operator[]`. |
| `0x0010fafc` | `int32_t SpriteBatch::End(SpriteBatch* sb)` | Seems to expand the mobile function `SpriteBatch::RenderSprites`, which itself would call `glDrawElements`, not sure if the 3DS version actually used this. Also expands mobile function `SpriteBatch::SetTexture` and directly calls `GraphicsDevice::SetTextureSlot`. |
| `0x0010fd28` | `SpriteInfo* SpriteBatch::Begin(SpriteBatch* sb, bool zoomEnable)` |  |
| `0x0010fda0` | `void Achievements::TriggerSystem::TriggerSystem(int32_t* arg1)` | Expands the mobile function `Achievements::TriggerSystem::ClearTriggers` |
| `0x0010fdbc` | `CameraZoomer* CameraZoomer::CameraZoomer(CameraZoomer* arg1)` | Seems to match somewhat to the mobile function. |
| `0x00110de8` | `void PlatformDevice::PlatformDevice(int32_t* arg1)` |  |
| `0x00111a80` | `void* UI::SetDefaultSettings(void* arg1)` |  |
| `0x00113ce4` | `int32_t _cfguInit()` |  |
| `0x00115198` | `void CreateColour(Colour* c, u32 R, u32 G, u32 B, u32 A)` | Creates a colour struct. |
| `0x00115228` | `void State::State(State* state)` |  |
| `0x00115240` | `int32_t* Timer::Timer(int32_t* arg1)` |  |
| `0x00115470` | `Sprite* Sprite::Sprite(Sprite* sprite, String* str)` |  |
| `0x00115548` | `MiniMap* MiniMap::MiniMap(MiniMap* miniMap)` |  |
| `0x001157c8` | `void NetPlayer::NetPlayer(int32_t arg1)` |  |
| `0x00115870` | `void* WorldView::WorldView(int32_t* arg1)` |  |
| `0x00118154` | `void Background::Background(int32_t* arg1, int32_t arg2)` |  |
| `0x00118198` | `int32_t Statistics::Init(void* arg1)` |  |
| `0x001193bc` | `int32_t SpriteBatch::InitializeIndexBuffer(void* arg1)` |  |
| `0x00119528` | `int32_t SpriteBatch::InitializeVertexBuffer(void* arg1)` |  |
| `0x00119698` | `void* BaseDrawable::BaseDrawable(BaseDrawable* arg1)` |  |
| `0x00119830` | `int32_t* ItemTextPool::ItemTextPool(void* arg1, int32_t arg2)` |  |
| `0x00119dbc` | `int32_t GraphicsDevice::SetTextureSlot(GraphicsDevice* device)` |  |
| `0x00119dcc` | `void* GraphicsDevice::GraphicsDevice(GraphicsDevice* arg1)` |  |
| `0x0011ec7c` | `void Item::Init(Item* item)` | Clears some item properties. |
| `0x0011ee54` | `int32_t Sprite::reload(Sprite* sprite, String* str)` |  |
| `0x0011effc` | `void* Waters::Waters(void* arg1, int32_t arg2)` |  |
| `0x0011f0c0` | `void* Lighting::Lighting(int32_t* arg1, int32_t arg2)` |  |
| `0x0011f19c` | `void* RainPool::RainPool(void* arg1)` |  |
| `0x0012104c` | `int32_t GraphicsDevice::GraphicsDevice_Check()` | Wrapper for `GraphicsDevice::GraphicsDevice` |
| `0x00122868` | `int32_t GraphicsDevice::AddCallback(GraphicsDevice* device, SpriteBatch* sb)` |  |
| `0x00122ac4` | `int32_t GraphicsDevice::QueryBuffer(GraphicsDevice* arg1, int32_t* arg2, int32_t arg3, uint8_t* arg4)` |  |
| `0x00124c98` | `void FinalDraw(int32_t arg1, int32_t arg2, int32_t arg3, void* arg4)` | Seems to match the call location of the mobile function `glDrawElements`, not sure if the 3DS version actually used this. Because its 3DS rendering this could be hard to decipher. |
| `0x00127418` | `void Rain::Rain(int64_t* arg1)` |  |
| `0x00128164` | `char* ItemText::ItemText(ItemText* itemText, int32_t arg2 @ r4)` |  |
| `0x0012820c` | `void Texture2D::convertToTextureSpace(float* arg1, void* arg2, int32_t* arg3)` |  |
| `0x0012cb80` | `int32_t StateManager::RemoveState(GameStateManager* gsm, int32_t arg2)` | *Verify, might not be correct. |
| `0x0012cdd8` | `void* StateManager::~StateManager(StateManager_VTable** arg1)` |  |
| `0x0012d2a0` | `void* GameStateManager::GameStateManager(GameStateManager* gsm, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x001326a0` | `int32_t free(int32_t* arg1)` |  |
| `0x001364bc` | `int32_t GameStateManager::GameStateManager_Check()` |  |
| `0x00137280` | `void nanosleep(int32_t arg1)` |  |
| `0x0013737c` | `void* Localization::InitIconMap(void* arg1)` |  |
| `0x001379d8` | `int32_t* HelperFunctions::stringToWString(int32_t* arg1, int32_t* arg2)` | *Verify |
| `0x00137c24` | `void ShowPopup(String* string)` | Might be 3DS specific popup code. |
| `0x00138d30` | `void* UI::UI(UI* ui, int32_t arg2 @ r4)` |  |
| `0x0013b8cc` | `void Item::Item(Item* item)` | Clears some item properties. |
| `0x0013ba8c` | `int32_t Main::IsTutorial()` |  |
| `0x0013bac4` | `void Main::PlaySound(s32 soundId)` | Plays a sound with a given id. |
| `0x0013f940` | `int32_t FastRandom::Next(int32_t* arg1, int32_t arg2)` | In place of FastRandom::Next() from mobile it seems. |
| `0x0013f9b4` | `s32 RandomNumberRange(int128_t* seed, s32 min, s32 max)` |  |
| `0x00140a20` | `int32_t* Localization::GetText(int32_t* arg1, void* arg2, String* arg3, void* arg4)` |  |
| `0x00141490` | `bool HelperFunctions::loadResourceFile(int32_t arg1, int32_t arg2, u32* fileSize, int32_t arg4)` |  |
| `0x00141558` | `int32_t HelperFunctions::readLine(void* arg1, int32_t* arg2, int32_t arg3, String* arg4)` |  |
| `0x00143670` | `int32_t malloc(uint32_t arg1)` |  |
| `0x00143ef4` | `Player* Player::GetPlayer()` |  |
| `0x00143f10` | `int32_t Netplay::IsSinglePlayer()` |  |
| `0x00145c94` | `void* new(uint32_t arg1)` | The value for the parameter does not seem to match with a specific type. |
| `0x001481fc` | `int32_t NetMessage::SendMessage()` |  |
| `0x001482dc` | `int32_t NetMessage::CreateMessage0(int32_t arg1)` |  |
| `0x00148aac` | `void* SpriteText::setText(void* arg1, int32_t* arg2)` |  |
| `0x00149a68` | `int32_t ResourceFile::size(void* arg1)` |  |
| `0x00149d00` | `int32_t* ResourceFile::close(int32_t* arg1)` |  |
| `0x00149d74` | `bool ResourceFile::readData(void* arg1, char* arg2, u32 fileSize, int32_t arg4)` | *Verify, definitely not the same compared to mobile but calling seems the same. |
| `0x0014a24c` | `ContentLoader* ContentLoader::ContentLoader(ContentLoader* arg1)` | Clears some data relating to what seems to be an image loader. |
| `0x0014a99c` | `int32_t* HelperFunctions::replaceSubString(int32_t* arg1, int32_t* arg2, int32_t* arg3, int32_t* arg4, int32_t arg5)` | *Verify |
| `0x0014b3e0` | `int32_t EE::String::Null(int32_t** arg1)` |  |
| `0x0014b594` | `void EE::String::~String(String* str)` |  |
| `0x0014b5bc` | `String* EE::String::operator=(String* str, String* arg2, void* arg3)` |  |
| `0x0014df8c` | `int32_t** Stopwatch::Stopwatch(int32_t** arg1)` |  |
| `0x0014e384` | `int32_t* new[](uint32_t arg1)` | *Verify |
| `0x0014f7b8` | `void* FreeStringType2(String* str)` |  |
| `0x00150230` | `void* SpriteText::setPosition(void* arg1)` |  |
| `0x001502a0` | `int32_t SpriteText::setBounds(void* arg1, int32_t* arg2)` |  |
| `0x00150330` | `void* SpriteText::regenerateMatrix(void* arg1)` |  |
| `0x00150390` | `int32_t SpriteText::getStringDimension(int32_t* arg1, void* arg2, int32_t* arg3)` |  |
| `0x00151f48` | `void* LocalNetworkGamer::SendData2(int32_t arg1, void* arg2, int32_t arg3, u32 arg4, int32_t arg5, void* arg6)` |  |
| `0x00151fa8` | `void LocalNetworkGamer::SendData(int32_t arg1, void* arg2, int32_t arg3, void* arg4)` |  |
| `0x00152090` | `String* EE::String::String(String* str1, char* rawStr)` |  |
| `0x001534a0` | `int32_t NetClient::IsReadyToReceive(void* arg1, char* arg2)` |  |
| `0x00155174` | `int32_t UI::UI_Check()` |  |
| `0x00156ea0` | `int32_t NetworkGamer::SendDataToThisGamer(void* arg1, char* arg2, u32 arg3)` |  |
| `0x00156f3c` | `int32_t GraphicsDevice::Lock(GraphicsDevice* arg1)` | *Verify |
| `0x00156f44` | `int32_t CriticalSection::Enter(int32_t* arg1)` |  |
| `0x00156f48` | `int32_t GraphicsDevice::Unlock(GraphicsDevice* device)` | *Verify |
| `0x00156f50` | `void CriticalSection::Leave(int32_t* arg1)` |  |
| `0x001572d8` | `int32_t O::Thread::Sleep(int32_t arg1)` |  |
| `0x00157330` | `int32_t EE::MemoryFile::Write(int32_t* arg1, char* arg2, u32 arg3, void* arg4)` |  |
| `0x00157de4` | `int32_t* BaseMenu::waitForBackgroundThread(void* arg1)` |  |
| `0x0015d054` | `uint32_t O::Runnable::WaitForCompletion(int32_t* arg1)` |  |
| `0x0015d71c` | `u32 MurmurHash3(String* string, u32 seed)` |  |
| `0x0015d8a8` | `int32_t Network::SendData(void* arg1, char* arg2, u32 arg3, int32_t* arg4)` |  |
| `0x0015dcf4` | `int32_t GlyphSet::GetGlyph(void* arg1, int32_t arg2)` |  |
| `0x00173914` | `int32_t setjmp(int32_t* arg1, int32_t arg2 @ r4, int32_t arg3 @ r5, int32_t arg4 @ r6, int32_t arg5 @ r7, int32_t arg6 @ r8, int32_t arg7 @ r9, int32_t arg8 @ r10, int32_t arg9 @ r11)` |  |
| `0x001749dc` | `void* showKeyboard(int32_t arg1, int32_t arg2, int32_t arg3, int32_t arg4)` | Might eventually call the 3ds keyboard menu. |
| `0x0017d97c` | `int32_t pngLoad(void* arg1, int32_t* arg2, int32_t* arg3, int32_t** arg4, int32_t* arg5, int16_t* arg6)` |  |
| `0x0017e0c4` | `int32_t fast_sin(int64_t arg1 @ q1)` |  |
| `0x0017e3f4` | `void LoadBackground()` | Loads Terraria's background images. |
| `0x0017f418` | `void Background::Draw(void* arg1, BaseMenuState* menuState @ r4)` | Not an exact match to the mobile version but the name is close enough. |
| `0x0017fc7c` | `int32_t Background::DrawBack_2()` |  |
| `0x0017fc94` | `int32_t* Background::DrawBack(void* arg1)` |  |
| `0x00180054` | `void DrawBackground(void* arg1, u32 backgroundType, int32_t arg3, Colour colour1 @ r9, int32_t arg5 @ r11, int32_t arg6, int32_t arg7)` | Draws a background. |
| `0x001809c8` | `uint32_t WorldView::DrawCursor(void* arg1)` |  |
| `0x001872b0` | `void* ItemWidget::ItemWidget(void*** arg1, String* str1, String* str2)` |  |
| `0x00187c9c` | `int32_t NetMessage::syncPlayer(int32_t arg1, int32_t arg2 @ r4, int32_t arg3 @ r5)` |  |
| `0x001886d8` | `int32_t NetMessage::syncPlayers()` |  |
| `0x00188844` | `int32_t NetMessage::SendItemInfo(int32_t arg1, int32_t arg2, int32_t arg3)` |  |
| `0x0018890c` | `int32_t NetMessage::SendPlayerId(void* arg1, int32_t arg2)` |  |
| `0x00188f04` | `int32_t NetMessage::CreateMessage1(int32_t arg1, int32_t arg2)` |  |
| `0x00189fb4` | `int32_t NetMessage::CreateMessage2_2(int32_t arg1, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x0018a940` | `int32_t NetMessage::CreateMessage2(int32_t arg1, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x0018b164` | `int32_t NetMessage::CreateMessage4(int32_t arg1, int32_t arg2, int32_t arg3, int32_t arg4, int32_t arg5)` |  |
| `0x0018b3ac` | `int32_t NetMessage::CreateMessage5(int32_t arg1, int32_t arg2, int16_t arg3, int16_t arg4, int16_t arg5, int32_t arg6, int32_t arg7)` |  |
| `0x0018b564` | `int32_t NetMessage::SendNpcCreated(int32_t arg1, int32_t arg2)` |  |
| `0x0018ba28` | `int32_t NetMessage::SendTeamChange(int32_t arg1, int32_t arg2, int32_t arg3)` |  |
| `0x0018be08` | `int32_t NetMessage::SendTileSquare(int32_t arg1, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x0018c2e8` | `int32_t NetMessage::SendTileChanged(int32_t arg1, int16_t arg2, int16_t arg3, int16_t arg4, int32_t arg5)` |  |
| `0x0018f69c` | `int32_t NetMessage::SendGoodEvilCount()` |  |
| `0x0019400c` | `int32_t NetMessage::SendPlayerWasKilled(int32_t arg1, int16_t arg2, int16_t arg3, int16_t arg4, int32_t arg5, int32_t arg6)` |  |
| `0x0019408c` | `int32_t NetMessage::SendAnnounceSpawning(int32_t arg1)` |  |
| `0x00194ba0` | `int32_t NetMessage::SendPlayerIDSessionMapping(void* arg1)` |  |
| `0x001a3178` | `int32_t Projectile::NewProjectile(int32_t arg1, int32_t arg2, int32_t arg3, int96_t arg4 @ q5)` |  |
| `0x001ab3a0` | `uint32_t Projectile::Kill(Projectile* projectile, int128_t arg2 @ q0)` | Equivalent to `Terraria.Projectile.Kill()`. |
| `0x001c0794` | `int32_t Projectile::Update(Projectile* arg1)` |  |
| `0x001c62a0` | `void ClearProjectile(Projectile* projectile)` | Clears some projectiles properties. |
| `0x001c7f0c` | `int32_t SpriteText::setRotation(void* arg1)` |  |
| `0x001c7fb0` | `int32_t SpriteText::checkFontName(int32_t arg1, int32_t* arg2)` |  |
| `0x001c8650` | `void SpriteText::setEdgeBehaviour(void* arg1, int32_t arg2)` |  |
| `0x001c86bc` | `void SpriteText::setVerticalAlign(void* arg1, int32_t arg2)` |  |
| `0x001c8718` | `void SpriteText::setHorizontalAlign(void* arg1, int32_t arg2)` |  |
| `0x001c8bd4` | `void* SpriteText::setText2(void* arg1, int32_t* arg2)` |  |
| `0x001c8cd8` | `void SpriteText::setScale(void* arg1, Vector2* vec)` | Expands mobile function `SpriteText::setTextScale`. |
| `0x001c9e10` | `void Statistics::logStat(int32_t arg1, int32_t arg2, int32_t* arg3)` |  |
| `0x001cebec` | `BaseMenuState* CreditsMenu::CreditsMenu(BaseMenuState* arg1, uint8_t arg2)` |  |
| `0x001d1564` | `void FullVersion::FullVersion(void*** arg1)` |  |
| `0x001d802c` | `void SoundEffect::Load(int32_t* arg1, String* str)` | Converts `str` to be a `.wav` file name. |
| `0x001d809c` | `int32_t ExtractState::OnActivate()` |  |
| `0x001d8228` | `int32_t ExtractState::Draw(ExtractState* arg1)` | No call references, seems to be stored at `0x005d64e8`. |
| `0x001d8370` | `int32_t LoadSplashSprites(int32_t arg1 @ r4)` |  |
| `0x001d837c` | `int32_t ExtractState::OnLoad(ExtractState* arg1)` |  |
| `0x001d8754` | `float ExtractState::Update(ExtractState* state, float arg2 @ q4)` |  |
| `0x001d8b18` | `ExtractState* ExtractState::ExtractState(ExtractState* arg1)` |  |
| `0x001d8be8` | `void SpriteBatch::DecreaseLayer(void* arg1)` |  |
| `0x001d8bf8` | `void SpriteBatch::IncreaseLayer(void* arg1)` |  |
| `0x001d8c68` | `void SpriteBatch::setCameraZoomFactor(SpriteBatch* sb, float cameraZoom @ q0)` |  |
| `0x001d90c4` | `uint32_t SpriteBatch::Draw3(SpriteBatch* arg1, Texture* texture, Vector2* pos, Vector4* vec, int64_t arg5 @ q6, u32 arg6, int32_t arg7, int32_t* arg8)` |  |
| `0x001d9630` | `void SpriteBatch::Draw2(SpriteBatch* arg1, Texture* texture, Vector2* vec2, Vector4* vec1, float Y, float X, int32_t* arg7)` |  |
| `0x001d9a44` | `void SpriteBatch::Draw(SpriteBatch* arg1, Texture* texture, Vector4* vec, Vector4* vec2, Colour* colour, void* arg6)` | There are a bunch of different functions with this name but difference parameters. |
| `0x001d9af4` | `SpriteBatch* SpriteBatch::Global()` |  |
| `0x001da168` | `int32_t SpriteSheet<_sheetSprites>::DrawScaled(int32_t arg1, int32_t arg2, int32_t arg3, int32_t arg4, int32_t arg5)` |  |
| `0x001dae68` | `int32_t* DrawFromAtlas(u32 id, Vector4* rect, Colour colour)` |  |
| `0x001dba50` | `int32_t XNASpriteBatch::Draw4(int32_t arg1, Vector2* arg2, int32_t arg3, int32_t arg4, int32_t arg5, int32_t arg6)` |  |
| `0x001dc760` | `int32_t* XNASpriteBatch::Draw3(int32_t arg1, Vector2* arg2, int32_t* arg3, char* arg4, int32_t arg5, int32_t arg6, int32_t arg7)` |  |
| `0x001dc858` | `uint32_t Underground::UpdateOnce()` |  |
| `0x001dc890` | `void* Underground::LoadContent()` |  |
| `0x001e2fdc` | `void* WidgetGroup::WidgetGroup(void*** arg1)` |  |
| `0x001e3624` | `void Achievements::TriggerSystem::ReadProfile(int32_t arg1, int32_t arg2)` |  |
| `0x001e366c` | `void* Achievements::TriggerSystem::UpdateAchievements(void* arg1)` |  |
| `0x001e39e0` | `uint32_t Achievements::AchievementSystem::AwardAllUnlocked(char* arg1)` | No call references, no variable reference. Might be named wrong, function at  |
| `0x001e3b28` | `uint32_t Achievements::AchievementSystem::Award(char* arg1, uint32_t arg2)` |  |
| `0x001e4058` | `Texture* BaseDrawable::SetTexture2(BaseDrawable* drawable, Texture* texture)` |  |
| `0x001e41cc` | `int32_t BaseDrawable::SetTexture(BaseDrawable* drawable, String* str_2)` |  |
| `0x001e43f4` | `int32_t* BaseDrawable::OnDeviceBufferChange(Sprite* sprite, int32_t arg2)` |  |
| `0x001e44b8` | `void BaseDrawable::setColor(Sprite* sprite, Colour* colour)` |  |
| `0x001e452c` | `BaseDrawable* BaseDrawable::~BaseDrawable(BaseDrawable* arg1)` |  |
| `0x001e7eb8` | `int32_t CameraZoomer::SetZoomDirect()` |  |
| `0x001e7ec8` | `float CameraZoomer::ApplyZoomToScreenPos(Vector2* pos, CameraZoomer* cameraZoomer, Vector2* scale)` |  |
| `0x001eb0a8` | `void* FindGameMenu::JoinGame(void* arg1)` |  |
| `0x001ee610` | `void* InputManager::InputManager(void** arg1)` |  |
| `0x001eeb84` | `char* WorldView::onStopGame(int32_t arg1)` | Expands mobile function `ItemTextPool::Clear`. |
| `0x001ef508` | `String* GetIconName(String* name, u32 iconType)` | Gets a terraria icon name with a given `iconType`. |
| `0x001ef9f8` | `int32_t Localization::LoadEntries(void* arg1)` | No call references, no variable reference. Seems to get skipped/placed inline in `Localization::SetLanguage`. |
| `0x001efa6c` | `int32_t Localization::SetLanguage(void* arg1, String* str)` |  |
| `0x001efdbc` | `void* Localization::AddIconsToText(void* arg1, int32_t* arg2)` |  |
| `0x001f027c` | `void* Localization::FillDictionary(void* arg1, void* fileData, u32 fileSize, u32 num)` |  |
| `0x001f07bc` | `int32_t Localization::GetLanguageSpecificFont(int32_t arg1, void* arg2, int32_t* arg3)` |  |
| `0x001f0c14` | `int32_t Localization::HasKey(void* arg1, int32_t* arg2, int32_t arg3, int32_t arg4)` | No call references, no variable reference.,No call references, no variable reference. On mobile its called in `NPC::ShowTownSpawnMessage`. |
| `0x001f3d7c` | `uint32_t ResourceFile::readUTF16Char(void* arg1, int32_t arg2, int32_t arg3, int32_t arg4)` | *Verify |
| `0x001f450c` | `int32_t ResourceFile::isValid(void* arg1)` |  |
| `0x001f453c` | `int32_t ResourceFile::readInt(void* arg1, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x001f558c` | `BaseMenuState* OptionsMenuBottom(BaseMenuState* arg1)` |  |
| `0x001f5708` | `uint32_t SpriteWidget::setTexture(void* SpriteWidget, String* str)` |  |
| `0x001f5848` | `int32_t* SpriteWidget::DeleteSprites(void* arg1)` |  |
| `0x001f598c` | `int32_t SpriteWidget::setupRollovers(u32 arg1)` |  |
| `0x001f6384` | `void StateManager::AbortUpdate(void* arg1)` |  |
| `0x001f63a4` | `int32_t StateManager::HandleInput(void* arg1)` |  |
| `0x001f6ca0` | `int32_t StateManager::ProcessCommands(void* arg1)` |  |
| `0x001f6f14` | `int32_t StateManager::Draw(StateManager* arg1)` |  |
| `0x001f6fe0` | `uint32_t StateManager::Update(void* arg1)` |  |
| `0x001f80b0` | `int32_t LoadSomeContent()` |  |
| `0x001fa56c` | `Texture* TextureAtlas::LoadPageAndBind(int32_t* arg1, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x001fac4c` | `uint8_t* TextureAtlas::GetRegionFromName(TerrariaAtlas* atlas, String* str)` |  |
| `0x001face8` | `int32_t TextureAtlas::GetIndexFromStrippedName(TerrariaAtlas* atlas, String* arg2)` |  |
| `0x001fad94` | `void* TextureAtlas::LoadPage(int32_t arg1, int32_t arg2, int32_t arg3)` |  |
| `0x001fc97c` | `int32_t* WidgetLoader::loadSprite(void* arg1)` |  |
| `0x001fccc8` | `void*** WidgetLoader::loadWidget(void* arg1, int32_t arg2 @ r5)` |  |
| `0x002021f8` | `int32_t WidgetLoader::load(int32_t* arg1, void* arg2 @ r4, int32_t arg3 @ r5)` |  |
| `0x00204fa4` | `void* ContentLoader::LoadTexture(ContentLoader* loader, String* str, u32 num1, String* str2, int32_t arg5 @ r5, int64_t arg6 @ q0, bool arg7)` | This is different from on mobile, textures are not loaded the same way. |
| `0x00205a3c` | `int32_t* ContentLoader::loadGlyphSet(ContentLoader* arg1, int32_t* arg2)` |  |
| `0x00207be4` | `int32_t ContentLoader::InvalidateAllTextures(int32_t* arg1 @ r6)` | No call references, no variable reference. On mobile this is called by `AndroidInterface::fjOnSurfaceDestroyed`. |
| `0x0020eb9c` | `int32_t MinimapHelper::Run(MiniMapHelper* helper)` |  |
| `0x0020fb50` | `int32_t TerrariaAtlas::GetFileExtension(int32_t arg1, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x0020fb7c` | `int32_t TerrariaAtlas::GetConversionForPage()` |  |
| `0x00210590` | `int32_t* TerrariaAtlas::GetFirstFrameContentEnclosingBoundingRectangle(int64_t* arg1)` |  |
| `0x00210720` | `int32_t TerrariaAtlas::~TerrariaAtlas(TerrariaAtlas_VTable** arg1)` |  |
| `0x00210738` | `int32_t TerrariaAtlas::~TerrariaAtlas2(TerrariaAtlas_VTable** arg1)` |  |
| `0x00218e2c` | `int32_t FlowSchemeNode::getNeighbour(void* arg1, int32_t arg2)` |  |
| `0x00219260` | `void GraphicsDevice::RemoveQuery(GraphicsDevice* device, int32_t arg2)` |  |
| `0x00219354` | `int32_t Texture2D::BindNewTexture(Texture* arg1, bool arg2, bool arg3, int32_t arg4)` |  |
| `0x002193cc` | `int32_t GraphicsDevice::QueryTexture(SpriteBatch* sb, Texture* texture, int32_t arg3)` |  |
| `0x00219858` | `int32_t GraphicsDevice::RemoveCallback(GraphicsDevice* device, int32_t arg2)` |  |
| `0x00219978` | `int32_t GraphicsDevice::GetZBufferState(GraphicsDevice* device)` |  |
| `0x00219988` | `int32_t GraphicsDevice::SetZBufferState(GraphicsDevice* device)` |  |
| `0x0021999c` | `int32_t Texture2D::IsQueuedForBinding(Texture* arg1)` |  |
| `0x002199d0` | `int32_t GraphicsDevice::IsTextureInQueue(void* arg1, int32_t arg2, int32_t arg3)` |  |
| `0x00219b64` | `int32_t Texture2D::IsBeingBound(Texture* arg1)` |  |
| `0x00219b94` | `int32_t GraphicsDevice::IsTextureBeingBound(Texture* arg1, int32_t arg2)` |  |
| `0x00219c14` | `int32_t GraphicsDevice::set2DScaledLetterboxed(GraphicsDevice* arg1)` | *Verify |
| `0x0021a088` | `int32_t GraphicsDevice::clear(GraphicsDevice* arg1)` |  |
| `0x0021a098` | `int32_t GraphicsDevice::set2D(GraphicsDevice* arg1)` |  |
| `0x0021b768` | `int32_t MenuBackground::Draw2(int32_t arg1)` |  |
| `0x0021b770` | `uint32_t MenuBackground::Draw(BaseMenuState* menuState)` | *Verify. No call references, no variable reference. According to the mobile versions its apart of a vtable, the ram dump i used is missing this i guess. |
| `0x0021b984` | `int32_t MenuBackground::Update2(int32_t arg1)` |  |
| `0x0021b98c` | `uint32_t MenuBackground::Update(BaseMenuState* menuState)` |  |
| `0x0021c610` | `int32_t MenuBackground::~MenuBackground(int32_t arg1)` |  |
| `0x0021dc90` | `uint32_t NetworkSession::Update(void* arg1)` |  |
| `0x0021de68` | `void NetworkSession::EndGame(void* arg1)` |  |
| `0x0021de74` | `void NetworkSession::StartGame(void* arg1)` |  |
| `0x0021f544` | `int32_t XNASpriteBatch::DrawString(XNASpriteBatch* arg1, String* str, Vector2* pos, Colour colour, void* arg5)` |  |
| `0x0021fa1c` | `SpriteBatch* XNASpriteBatch::Initialize(XNASpriteBatch* arg)` | Matches the mobile functions but not called in the same places. Also expands `SpriteBatch::SetGlobalSpriteBatch`. |
| `0x0021fa80` | `SpriteBatch* XNASpriteBatch::Unitialize(XNASpriteBatch* arg1)` |  |
| `0x0021fbec` | `int32_t XNASpriteBatch::MeasureString(int32_t* arg1, XNASpriteBatch* arg2, void* arg3)` |  |
| `0x002200c4` | `void XNASpriteBatch::XNAToOctarineOrigin(int32_t arg1, Texture* texutre, void* arg3, int32_t* arg4)` | *Verify |
| `0x0022019c` | `int32_t XNASpriteBatch::End(XNASpriteBatch* drawer)` |  |
| `0x00220590` | `int32_t* XNASpriteBatch::Draw2(XNASpriteBatch* arg1, Texture* arg2, Vector2* arg3, void* arg4, char* arg5, int32_t* arg6, int32_t* arg7, int32_t arg8)` |  |
| `0x00220810` | `void XNASpriteBatch::Draw(XNASpriteBatch* arg1, Texture* texture, IVector4* src, IVector4* dest, Colour* colour)` | There are a bunch of different functions with this name but difference parameters. |
| `0x0022096c` | `void* SpriteBatch::Begin(SpriteBatch::Global())_2(XNASpriteBatch* drawer, bool zoomEnable, int32_t arg3, int32_t arg4)` | Almost identical to `SpriteBatch::Begin(SpriteBatch::Global())` at `0x002209e8`, but seems to return a value and call `SpriteBatch::Begin` differently (`b` instead of `bl`) |
| `0x002209e8` | `void SpriteBatch::Begin(SpriteBatch::Global())(XNASpriteBatch* drawer)` | Matches `SpriteBatch::Global()` but locations are different.,This seems to exist where `SpriteBatch::Begin(SpriteBatch::Global())` does on mobile, functionally its the same. |
| `0x00220b5c` | `s32 QuestFishTypeToId(u32 questID)` | Returns the quest fish item id relating to the given `questID`. |
| `0x0022b4b8` | `void HelperFunctions::isPowerOf2(int32_t arg1)` | Binary Ninja might be hiding the code, it can be viewed in assembly mode. |
| `0x0022b928` | `int32_t HelperFunctions::intToString(String* name, s32 itemId, int32_t arg3, int32_t arg4 @ r7)` | *Verify |
| `0x0022cec4` | `int32_t HelperFunctions::stringContains(int32_t* arg1, int32_t* arg2)` |  |
| `0x0022d650` | `int32_t HelperFunctions::replaceSubString(int32_t arg1, int32_t* arg2, int32_t* arg3, int32_t* arg4, int32_t arg5)` | *Verify |
| `0x0022efe8` | `int32_t HelperFunctions::nearestPowerOfTwoGreater(int32_t arg1)` |  |
| `0x0022f008` | `int32_t HelperFunctions::insertStringPreFileExtension(int32_t arg1, int32_t* arg2, int32_t* arg3, u32 arg4 @ r4)` | *Verify |
| `0x00230568` | `void** HelperFunctions::tokenize(int32_t* arg1, int32_t* arg2, int32_t* arg3, int32_t arg4)` | *Verify |
| `0x002354d4` | `int32_t PlatformHelpers::GetXmlPostfixes(int32_t* arg1)` |  |
| `0x00236f30` | `uint32_t PauseMenu::BackToGame(void* arg1, int32_t arg2 @ r4)` |  |
| `0x00237b3c` | `void LoadSound(SoundEffect* sound, String* str, int32_t arg3)` | Loads a sound. |
| `0x00237c50` | `void LoadSound2(SoundEffect* sound, String* str, int32_t arg3)` | Loads a sound. |
| `0x00237d6c` | `void ClearSoundEffect(SoundEffect* sound)` |  |
| `0x00237e58` | `int32_t* StateFullEngine::AddTransition(void* arg1, void* arg2, void* arg3, int32_t arg4 @ q4)` |  |
| `0x002382bc` | `int32_t StateFullEngine::AddState(void* arg1, void* arg2, int32_t arg3, int32_t arg4, int32_t arg5 @ r4, int32_t arg6, int32_t arg7)` |  |
| `0x0023ba04` | `int32_t LoadAtlas(int32_t arg1, int32_t* arg2, TerrariaAtlas* atlas)` | Probably loads an atlas, it is unknown if it has a mobile version counterpart. |
| `0x0023bfe4` | `int32_t TabCrafting::GetTextureRegionIdentifierForNeededLiquid(char** arg1, int32_t arg2, int32_t arg3)` |  |
| `0x0023ec1c` | `int32_t WorldMapMenu::UpdateOpened(void* arg1)` |  |
| `0x0023efa4` | `int32_t MiniMap::AdjustMapScale(void* arg1, int32_t arg2)` |  |
| `0x002435ac` | `int32_t GameStateManager::Initialize_2(void* arg1 @ r4)` | *Verify, No call references, no variable reference. This does not match the mobile function. |
| `0x002435d8` | `int32_t GameStateManager::Initialize(GameStateManager* arg1)` |  |
| `0x0024434c` | `char* LoadMenuStates(GameStateManager* gsm)` |  |
| `0x00245b90` | `int32_t GameStateManager::DestroyInstance(void* arg1)` |  |
| `0x00246298` | `int32_t GameStateManager::draw(GameStateManager* arg1)` | Seems to draw everything. There a a bunch of `nop`s so patching might be easy.  Does not match the mobile function. |
| `0x002465e0` | `int32_t GameStateManager::update(GameStateManager* gsm)` |  |
| `0x002481c8` | `BaseMenuState* OptionsMenu::OptionsMenu(BaseMenuState menu @ r0)` |  |
| `0x0024e4f0` | `int32_t* InitBackgroundDirt(void*** arg1, BaseMenu* menu, int32_t arg3 @ r4)` | Probably a 3ds specific function. |
| `0x002588ec` | `void ReleaseNPC(s32 X, s32 Y, s32 npcId, u32 style, s32 who)` | Equivalent to `Terraria.NPC.ReleaseNPC()`. |
| `0x0025c97c` | `u32 NPC::SpawnFriendlyNPC(int32_t* arg1)` |  |
| `0x0025cfa0` | `void NPC::setFireFlyChance()` |  |
| `0x00265758` | `int32_t TerrariaInitializer::Run()` | No call references, no variable reference. Probably close to the entry point. |
| `0x002681d0` | `int32_t O::Runnable::IsDoneOrInterupted(void* arg1)` |  |
| `0x0026ba00` | `uint32_t ControllerFlowScheme::move(void* arg1, int32_t arg2)` |  |
| `0x00274ab8` | `char** CharacterCreateMenu::onKeyboardInputDone(int32_t arg1, int32_t* arg2, int32_t arg3 @ r4)` | No call references, seems to be stored at `0x005d83cc`. |
| `0x0027a0cc` | `void KillFrostLegionEnemy(int32_t arg1, NPC* npc)` |  |
| `0x002945e0` | `String* EE::String::Format(String* destStr, char* formatStr, void* args)` |  |
| `0x002946cc` | `String* LoadString(String* arg1, String* dest, char* raw)` |  |
| `0x00295474` | `void UI::Initialize(void* arg1)` |  |
| `0x0029550c` | `int32_t UI::UpdateOnce()` |  |
| `0x002956a8` | `uint32_t UI::JoinSession(void* arg1, u32 arg2)` |  |
| `0x002956d8` | `int32_t Load_texture_touchzoom(int32_t arg1 @ r4)` | Loads "UI/texture_touchzoom.png" but this file (the string) exists nowhere in the cartridge dump. |
| `0x002969f8` | `void UI::LeaveSession(void* arg1)` |  |
| `0x00297c84` | `void UI::DrawInterface(void* arg1)` |  |
| `0x002980d0` | `int32_t UI::MeasureString(int32_t* arg1, void* arg2)` |  |
| `0x002980e0` | `int32_t UI::UpdateNpcChat(PlayerParentPlaceholder* arg1, int32_t arg2 @ r4)` |  |
| `0x002990b4` | `int32_t UI::CloseInventory()` |  |
| `0x00299240` | `int32_t UI::DrawStringScaled(String* arg1, Vector2* arg2, Colour arg3, void* arg4)` |  |
| `0x00299760` | `Colour UI::UpdateCursorColor(int64_t arg1 @ q4)` |  |
| `0x0029ce40` | `uint32_t UI::DrawMultiplayerHeadIndicator(void* arg1, void* arg2, int64_t arg3 @ q1)` |  |
| `0x0029d304` | `int32_t UI::Draw(BaseMenuState* arg1)` |  |
| `0x0029d4f8` | `int32_t UI::ExitGame(int32_t arg1, int32_t arg2)` |  |
| `0x0029d5d4` | `void UI::HelpText(PlayerParentPlaceholder* arg1)` | Somewhat equivalent to `Terraria.Main.HelpText()`. |
| `0x0029f570` | `int32_t UI::OpenView(void* arg1, int32_t arg2 @ r4)` | Calls `UI::InitPlayerStorage` on mobile but its expanded out and calls `UI::SetDefaultSettings` directly. |
| `0x0029f6d4` | `uint32_t UI::StopGame(void* arg1, int32_t arg2)` |  |
| `0x0029f858` | `s32 TownNPCFromId(void* arg1, s32 npcId)` | Gets a town NPC id from the given `npcId` |
| `0x0029f9d4` | `int32_t* UI::setPlayer(void* arg1, void* arg2)` |  |
| `0x0029fb08` | `uint32_t UI::setPlayer2(void* arg1, u32 arg2)` |  |
| `0x002b084c` | `void _cfguExit2(int32_t arg1)` | Exist out of the `cfg:u` service. |
| `0x002b2148` | `int32_t _cfguExit()` | Exist out of the `cfg:u` service. |
| `0x002fb5e0` | `u32 StringLength(char* raw)` |  |
| `0x002fb6c8` | `int32_t delete[](int32_t* arg1)` | *Verify |
| `0x002fb9a8` | `String* SetStringTypeString(String* strType, char* rawStr, void* arg3)` |  |
| `0x002fba24` | `String* FreeStringType4_2(String* str)` |  |
| `0x002fba2c` | `String* FreeStringType4(String* str)` |  |
| `0x002fba8c` | `int32_t delete(int32_t* arg1)` |  |
| `0x002fbfa6` | `char* Memcpy_aligned2(char* dest, char* src, u32 length, void* arg4)` |  |
| `0x002fd558` | `String* EE::String::operator=2(String* str1, String* str2)` |  |
| `0x002fd91c` | `void memcpy(char* dest, char* src, u32 length, void* arg4, void* arg5 @ r12)` |  |
| `0x002fd9bc` | `void* FreeString3_2(String* str)` |  |
| `0x002fd9c4` | `void* FreeStringType3(String* str)` |  |
| `0x002fe388` | `int32_t __aeabi_idivmod(int32_t arg1, uint32_t arg2)` |  |
| `0x00300b0c` | `bool CheckOnce(bool* flag)` | Returns `true` if `flag` was `false` then sets `flag` to `true`, otherwise (if `flag` is `true`) returns `false`.,Seems to be in place of `__cxa_guard_release()` on mobile. |
| `0x00300e10` | `int32_t memset(char* arg1, int32_t arg2)` |  |
| `0x00303768` | `int32_t sprintf(int16_t* arg1, int32_t arg2, int16_t* arg3)` |  |
| `0x0032aaa8` | `int32_t Cue::Load(void* arg1, int32_t* arg2)` |  |
| `0x0032b0d0` | `int32_t Cue::IsPlaying(void* arg1)` |  |
| `0x0032ed58` | `u32 NPC::SpawnBunny(s32 X, s32 Y)` | Spawn a bunny and does checks for seasons and stuff. |
| `0x0032eea8` | `uint32_t NPC::BrainBossAI(void* arg1)` |  |
| `0x00334c78` | `s32 NPCToBanner(s32 npcId)` | Equivalent to `Terraria.Item.NPCtoBanner()`. |
| `0x00336c38` | `int32_t SetDefaults_NPC(NPC* npc, u16 npcId @ r11, int32_t arg3, int32_t arg4)` | Equivalent to `Terraria.NPC.SetDefaults(int, float)`. |
| `0x00342084` | `uint16_t SetDefaultName_NPC(void* npc, String* npcName)` | Equivalent to `Terraria.NPC.SetDefaults(string)`. |
| `0x0034cdb4` | `u32 SpawnSnowmanEnemy(int32_t arg1 @ r4, int32_t arg2 @ r8)` | Spawn a snowman from the Frost Legion. |
| `0x0034ce3c` | `u32 SpawnLiquidNPC(int32_t* arg1)` |  |
| `0x0034e39c` | `s32 GetNPCIndex(s32 npcId)` |  |
| `0x0034e728` | `u32 CountNPCs2(u32 npcId)` |  |
| `0x0034e72c` | `u32 NPC::AnyNPCs(u32 npcId)` | Equivalent to `Terraria.NPC.CountNPCS()`. |
| `0x00350490` | `u32 NPC::SpawnUniqueNPC(int32_t* arg1, int32_t arg2 @ r4, int32_t arg3 @ r5)` |  |
| `0x00351848` | `uint32_t NPC::DrawColoredinfo(NPC* npc, void* arg2, int32_t arg3, int32_t arg4)` |  |
| `0x003708e8` | `uint32_t NPC::BrainBossOrbitersAI(void* arg1)` |  |
| `0x00372c1c` | `u32 NPC::SpawnPositionBasedNPC(int32_t* arg1)` |  |
| `0x003765a8` | `int32_t NPC::AI(NPC* arg1)` |  |
| `0x0037c908` | `int32_t NPC::Reset(int32_t arg1 @ r4, int32_t arg2 @ r5)` |  |
| `0x0037d7b8` | `u32 NPC::NewNPC(s32 X, s32 Y, s32 npcId, int32_t arg4, int32_t arg5 @ r4)` | Equivalent to `Terraria.NPC.NewNPC()`. |
| `0x0038130c` | `bool AnyNPCs(u32 npcId)` | Equivalent to `Terraria.NPC.AnyNPCs()`. |
| `0x00387d4c` | `void NPC::NPCLoot(NPC* npc)` | Equivalent to `Terraria.NPC.NPCLoot()`. |
| `0x00391d30` | `int32_t NPC::GetTexId(NPC* npc)` | Does not match the mobile functions exactly. |
| `0x00393b48` | `void SpawnWOF(Vector2 pos)` | Equivalent to `Terraria.NPC.SpawnWOF()`. |
| `0x00397100` | `int32_t NPC::setNames()` |  |
| `0x003a3424` | `int32_t NPC::UpdateAll()` |  |
| `0x003a3618` | `uint32_t NPC::UpdateNPC(NPC* arg1, int32_t arg2 @ r11, int32_t arg3)` |  |
| `0x003a6a48` | `void* NPC::Init(int32_t arg1)` |  |
| `0x003a8af8` | `void DustPool::Init(void* arg1)` |  |
| `0x003a8b50` | `void Dust::Init(char* arg1)` |  |
| `0x003a9b68` | `void Gore::Init(void* arg1)` |  |
| `0x003aa4f0` | `uint32_t Gore::DrawAll()` |  |
| `0x003aae00` | `int32_t* Gore::UpdateAll()` |  |
| `0x003ac694` | `int32_t Item::SetDefaults_String(Item* arg1, String* itemName @ r9)` | Equivalent to `Terraria.Item.SetDefaults(string)`. |
| `0x003adfdc` | `void Item::SetDefaults(Item* arg1, u32 id, u32 stack)` | Equivalent to `Terraria.Item.SetDefaults(int, ...)`. |
| `0x003c2008` | `int32_t Item::SetDefaults_SetAndroidPet(Item* arg1 @ r4, uint8_t arg2 @ r5, uint8_t arg3 @ r6, uint16_t arg4 @ r9)` |  |
| `0x003c57d8` | `int32_t Item::SetDefaults_Finish(Item* item @ r4, uint16_t arg2, int32_t arg3, int32_t arg4, int32_t arg5, int32_t arg6, int32_t arg7, int32_t arg8, int32_t arg9, int32_t arg10, int32_t arg11)` |  |
| `0x003c5c20` | `void NetDefaults_Item(Item* item, s32 id, u32 stack)` | Equivalent to `Terraria.Item.netDefaults()`. |
| `0x003c73a4` | `int32_t Item::CanBePlacedInAmmoSlot(void* arg1)` |  |
| `0x003c76f4` | `u32 MergeItems(Item* item1, Item* item2)` | Merges 2 items into a single stack. |
| `0x003c77c0` | `bool Item::Prefix(Item* item, s32 prefix, int128_t arg3 @ q4)` | Equivalent to `Terraria.Item.Prefix()`. |
| `0x003c9674` | `u32 Item::NewItem(u32 X, u32 Y, s32 width, s32 height, u32 id, u32 stack, int32_t arg7, s32 prefix, int32_t arg9)` | Equivalent to `Terraria.Item.NewItem()`. |
| `0x003c9e2c` | `u32 GetValueSell(u32 platinum, u32 gold, u32 silver, u32 copper)` | Equivalent to `Terraria.Item.sellPrice()`. |
| `0x003c9f24` | `uint32_t Item::FindOwner(Item* arg1, int32_t arg2, int64_t arg3 @ q0)` |  |
| `0x003ca190` | `u32 GetValueBuy(u32 platinum, u32 gold, u32 silver, u32 copper)` | Equivalent to `Terraria.Item.buyPrice()`. |
| `0x003cb378` | `int32_t Lang::itemAffixName(int32_t** arg1, Item* item)` |  |
| `0x003cdd9c` | `int32_t Lang::IsRomanAlphabet()` |  |
| `0x003cf368` | `int32_t Lang::setLang(int32_t arg1)` |  |
| `0x003d1a90` | `int32_t Lang::getGender(String* arg1, int32_t* arg2)` |  |
| `0x003d1ec0` | `void Main::Initialize()` |  |
| `0x003d25e4` | `int32_t Main::LoadContent(void* arg1)` |  |
| `0x003d339c` | `uint32_t DoCommand(String* command @ r7)` | Seems to be a place for debug commands, i think its inaccessible though. |
| `0x003d8efc` | `int32_t Main::UpdateServer()` |  |
| `0x003d9224` | `int32_t Main::DrawSolidRect(Vector4* arg1, Colour arg2)` |  |
| `0x003d92a8` | `int32_t Main::GetMainPlayer()` | Expands to `player[Main::MainPlayerIndex]`. |
| `0x003d9304` | `void Main::LoadingThread(void* mainInstance)` | Somewhat equivalent to `Terraria.Main.LoadContent()`, but only for audio. |
| `0x003da050` | `int32_t* Main::UpdateNetwork()` |  |
| `0x003daaac` | `int32_t* Main::InitializePostSplash(void* arg1)` |  |
| `0x003db4fc` | `void Main::Draw(void* arg1)` | Draws most of the top screen stuff. Not hearts, selected item, mana or buffs. This is called at `0050f2fc` which is fallowed by 2 `nop`s so there is enough room to hook this and call it yourself. |
| `0x003db74c` | `int32_t Main::Update_2()` |  |
| `0x003db764` | `uint32_t Main::Update(void* arg1)` |  |
| `0x003dbaf8` | `int32_t* Main::DrawRect(int32_t* arg1, Colour arg2, int32_t arg3)` |  |
| `0x003dbc30` | `int32_t Main::JoinGame(UI* arg1)` |  |
| `0x003dbf10` | `int32_t Main::PlayMusic(int32_t arg1, int32_t arg2)` |  |
| `0x003dbfb4` | `void Main::PlaySound_At(u32 type, u32 X, u32 Y, u32 style)` | Equivalent to `Terraria.Main.PlaySound()`. |
| `0x003dc9a4` | `uint32_t Main::StartGame()` |  |
| `0x003dce4c` | `int32_t Main::Main_2()` |  |
| `0x003dce64` | `Main* Main::Main(Main* main)` |  |
| `0x003dd27c` | `int32_t Main::~Main()` |  |
| `0x003e01c0` | `int32_t Tile::InitLookupTables()` |  |
| `0x003e585c` | `void Tile::kill(Tile* t, int32_t arg2, int32_t arg3, int32_t arg4)` |  |
| `0x003e59b4` | `void Tile::InitAnim()` |  |
| `0x003e8874` | `bool Time::CheckEaster()` | Doesn't seem to match mobile. |
| `0x003e9084` | `bool Time::CheckHalloween()` | Doesn't seem to match mobile. |
| `0x003e90c8` | `bool Time::CheckValentine()` | Not the same as mobile. |
| `0x003e93cc` | `bool Time::CheckOctoberFest()` |  |
| `0x003e9410` | `bool Time::CheckThanksgiving()` |  |
| `0x003e9558` | `int32_t Time::reset(void* arg1)` |  |
| `0x003e9780` | `bool Time::CheckXMas()` | Doesn't seem to match mobile. |
| `0x003f6bd0` | `uint32_t Chest::SetupShop(Chest* inv, u32 npcType, Player* player)` | Equivalent to `Terraria.Chest.SetupShop()`. |
| `0x003f9040` | `void Chest::Chest(Chest* chest)` | Clears data of a chest. |
| `0x003ff494` | `int32_t Mount::Initialize()` |  |
| `0x004005e0` | `void Mount::AnimState::AnimState(int32_t* arg1)` |  |
| `0x004005f8` | `int32_t Mount::MountData::MountData(void* arg1)` |  |
| `0x00400964` | `int32_t State::HandleInput()` |  |
| `0x00400974` | `int32_t State::GetStateFlags()` |  |
| `0x00402f70` | `int32_t Liquid::QuickWater(int32_t arg1 @ r10, int32_t arg2 @ r11, int32_t arg3, int32_t arg4, int32_t arg5, int32_t arg6)` |  |
| `0x00403b70` | `void Liquid::QuickSettleOn()` |  |
| `0x00403b88` | `void Liquid::QuickSettleOff()` |  |
| `0x004083dc` | `void* Player::UsePickaxe(Player* player, Item* item, void* arg3)` |  |
| `0x00408bf4` | `Player* Player::FindClosest(Rect* rect)` |  |
| `0x0040be30` | `void Player::UpdatePlayer(Player* player, u32 playerId)` | *Verify |
| `0x0041a944` | `int32_t Player::ClearInventory(void* arg1, int32_t arg2 @ r4)` |  |
| `0x0042ab9c` | `int32_t Player::GetCurrentlyMinedTileDamage(Player* player)` |  |
| `0x0042ac10` | `int32_t Player::SetCurrentlyMinedTileDamage(void* arg1, int32_t arg2)` |  |
| `0x0042d5d8` | `uint32_t Player::Hurt(Player* arg1, float arg2, int32_t arg3, int32_t arg4, int32_t arg5)` |  |
| `0x0042e088` | `void* Player::Init(Player* player)` |  |
| `0x0042f5c4` | `void Player::Spawn(Player* player, int32_t arg2 @ r4)` |  |
| `0x0042fe14` | `void Player::KillMe(Player* player_1, int32_t arg2 @ r7, int32_t arg3 @ r11, int32_t arg4, int32_t arg5, int64_t arg6)` |  |
| `0x00433c6c` | `uint32_t Player::DrawInfo(Player* player, void* arg2, int32_t arg3 @ r4, int32_t arg4 @ r5)` |  |
| `0x00436324` | `int32_t Player::Teleport(void* arg1, int32_t* arg2, int32_t arg3)` |  |
| `0x0044212c` | `int32_t Player::ItemSpace(Player* arg1, Item* item)` |  |
| `0x00442438` | `int32_t Player::RandColor(int32_t arg1)` |  |
| `0x0044259c` | `int32_t Player::Randomize(void* arg1)` |  |
| `0x004427e0` | `void* Player::Player(void*** arg1)` |  |
| `0x00447bdc` | `void Recipe::SetupRecipes()` | Equivalent to `Terraria.Recipe.SetupRecipes()`. |
| `0x0045305c` | `void SetupRecipes2(Item* arg1 @ r5, Item* arg2 @ r6, Item* arg3 @ r7, char* arg4 @ r10)` | Section 2 of `SetupRecipes`. |
| `0x00459044` | `void SetupRecipes3(void* arg1 @ r4, Item* arg2 @ r5, Item* arg3 @ r6, Item* arg4 @ r7, char* arg5 @ r8, int16_t arg6 @ r9, int32_t arg7 @ r10, int32_t arg8, int32_t arg9, int32_t arg10, int32_t arg11, int32_t arg12, int32_t arg13, int32_t arg14, int32_t arg15, int32_t arg16)` | Section 3 of `SetupRecipes`. |
| `0x0045a148` | `void Recipe::AddRecipe(void* arg1, void* arg2, void* arg3, void* arg4)` | Somewhat equivalent to `Terraria.Recipe.addRecipe()`, but different. |
| `0x0045b9e4` | `int32_t Sprite::SetTexture2(Sprite* sprite, Texture* texture)` |  |
| `0x0045ba54` | `int32_t Sprite::SetTexture(Sprite* sprite, String* str)` |  |
| `0x0045bc44` | `int32_t Sprite::OnContextLoss(Sprite* sprite)` |  |
| `0x0045c314` | `void BaseDrawable::setColor2(Sprite* arg1, char* arg2)` |  |
| `0x0045c48c` | `void Sprite::~Sprite2(Sprite* sprite)` |  |
| `0x0045c4a8` | `void Sprite::~Sprite(Sprite* sprite)` |  |
| `0x0045e548` | `int32_t Waters::FindWaterfalls(void* arg1)` |  |
| `0x0045ea60` | `int32_t Waters::Draw(int32_t* arg1, int32_t arg2)` |  |
| `0x0045ede0` | `int32_t Waters::DrawStyle(void* arg1, float arg2 @ r7, int32_t arg3, int32_t arg4, int32_t arg5, int32_t arg6)` |  |
| `0x00460994` | `void Widget::PlayClickSound(int32_t arg1)` |  |
| `0x00462eb8` | `void* Widget::Widget(void*** arg1)` |  |
| `0x00463b90` | `SpriteBatch* Console::initInstance(void* arg1)` |  |
| `0x00464fb4` | `void SetNpcCatchable()` | Sets the array of catchable NPCs. |
| `0x00467b40` | `int32_t Tile::InitAnim_2()` |  |
| `0x0046cf94` | `int32_t GetAnglerReward(Player* player)` | Gets the angler reword. |
| `0x0046e830` | `u32 GetQuestFishId()` | Calls `s32 QuestFishTypeToId(u32 questID)` on the current quest fish. |
| `0x00470090` | `void LoadWorldFileHeader2(FileReader* reader, int32_t arg2)` |  |
| `0x00472c28` | `void MiniMap::onStartGame(MiniMap* miniMap)` |  |
| `0x00472cf4` | `void MiniMap::SetMapScale(MiniMap* arg1, float scale @ s0)` |  |
| `0x00472db4` | `int32_t MiniMap::drawIconsNPCs(void* arg1, int32_t arg2)` |  |
| `0x004744d8` | `int32_t MiniMap::calculateNpcHeadPosition(void* arg1, void* arg2, int32_t arg3 @ q1)` |  |
| `0x00474594` | `int32_t MiniMap::getMinimapDrawColor(void* arg1)` | Expands mobile function `Color::LinearColorBlend`. |
| `0x00474fa0` | `int32_t MiniMap::CreateMap(MiniMap* map, int32_t arg2)` |  |
| `0x00475e74` | `void* Netplay::Disconnect()` |  |
| `0x004766bc` | `int32_t Netplay::StartServer()` |  |
| `0x004768f4` | `int32_t Netplay::CreateSession()` |  |
| `0x00476db0` | `void* Netplay::HookSessionEvents()` |  |
| `0x00476e68` | `int32_t Netplay::GamerLeftEventHandler(void* arg1)` |  |
| `0x0047722c` | `void Netplay::SetAsRemotePlayerSlot(uint32_t arg1)` |  |
| `0x0047724c` | `uint32_t Netplay::GamerJoinedEventHandler(void* arg1)` |  |
| `0x00479730` | `uint32_t Network::Update(void* arg1)` |  |
| `0x0047a67c` | `int32_t XMLFile::readString(int32_t arg1, void* arg2, int32_t* arg3)` |  |
| `0x0047ace4` | `int32_t XMLFile::getAttribute(int32_t arg1, void* arg2, int32_t* arg3)` | *Verify |
| `0x0047c698` | `int32_t XMLFile::gotoNode(void* arg1, int32_t arg2)` |  |
| `0x0047c714` | `int32_t* XMLFile::hasChild(void* arg1, int32_t* arg2)` |  |
| `0x0047c740` | `int32_t XMLFile::readBool(void* arg1)` |  |
| `0x0047c8d0` | `int32_t XMLFile::gotoChild(void* arg1, int32_t* arg2)` |  |
| `0x0047c940` | `int32_t XMLFile::gotoStart(void* arg1)` |  |
| `0x0047ca3c` | `void* XMLFile::XMLFile(void*** arg1, int32_t arg2)` |  |
| `0x0047d728` | `int32_t BaseMenu::HandleInput(BaseMenu* arg1)` |  |
| `0x0047e068` | `int32_t BaseMenu::applyGamepadInput(BaseMenu* menu, int32_t arg2, int32_t arg3)` |  |
| `0x0047e838` | `int32_t BaseMenu::WidgetSelectedByController()` |  |
| `0x0047e83c` | `int32_t BaseMenu::IsControllerMenuTraversalEnabled(BaseMenu* arg1)` |  |
| `0x0047e8d8` | `uint32_t BaseMenu::Draw(BaseMenu* menu)` |  |
| `0x0047ea38` | `int32_t BaseMenu::Exit(BaseMenu* menu)` |  |
| `0x0047ea8c` | `int32_t BaseMenu::Enter(BaseMenu* baseManue)` |  |
| `0x0047eb58` | `int32_t BaseMenu::Update(void* arg1)` |  |
| `0x0047f40c` | `void ChatLine::NewText(String* arg1, u8 a, u8 b, u8 c, u8 d)` |  |
| `0x00481fcc` | `int32_t DustPool::TeleportEffect(void* arg1, int32_t* arg2, int32_t arg3)` |  |
| `0x004824cc` | `int32_t DustPool::DrawDust(int32_t arg1, void* arg2)` |  |
| `0x00482d44` | `uint32_t GlyphSet::ReadGlyphs(int32_t* arg1, void* arg2)` |  |
| `0x00482f34` | `uint32_t GlyphSet::LoadFromFile(int32_t* arg1, void* arg2, int32_t arg3, int32_t arg4, int32_t arg5 @ r6)` | No call references, no variable reference. On mobile its called in `GlyphSet::GlyphSet`. Also expands mobile function `GlyphSet::ClearBorderColor`. |
| `0x004831e4` | `Texture* GlyphSet::LoadGlyphsetTexture()` |  |
| `0x0048337c` | `int32_t GlyphSet::GenerateFromDataFile(int32_t arg1, int32_t arg2, int32_t* arg3 @ r4, int32_t* arg4 @ r11)` |  |
| `0x00483b54` | `int32_t GlyphSet::AddGlyph(int32_t* arg1, int32_t arg2, int32_t arg3, int96_t arg4 @ q4, int32_t arg5, int32_t arg6, int32_t arg7, int32_t arg8)` |  |
| `0x00483d80` | `int32_t* GlyphSet::GlyphSet(int32_t* arg1, Texture* arg2)` |  |
| `0x00484270` | `void ItemText::Init(char* arg1)` |  |
| `0x0048e030` | `int32_t* DrawItemSlot(Draw_Unk2* arg1, int32_t* arg2, s32 num1, String* str1, int32_t arg5)` |  |
| `0x0048f984` | `int32_t MainMenu::Play()` | No call references, no variable reference. |
| `0x00490a88` | `BaseMenuState* MainMenu::MainMenu(BaseMenuState* arg1)` |  |
| `0x004974b0` | `void TileAnim::Init(void*** arg1, int16_t arg2, char arg3, int32_t arg4, int32_t arg5, int32_t arg6)` |  |
| `0x00497810` | `void TileInfo::Init(int32_t* arg1, int32_t arg2, int32_t arg3, int32_t arg4, char arg5, char arg6, char arg7, int16_t arg8, char arg9, int16_t arg10, char arg11, char arg12)` |  |
| `0x00498510` | `int32_t MainMenu::Tutorial(int32_t arg1 @ r4, int32_t arg2 @ r5)` |  |
| `0x0049bb04` | `int32_t WorldGen::CountTiles(int32_t arg1)` |  |
| `0x004a14a0` | `void* WorldGen::WaterCheck()` |  |
| `0x004a17a4` | `void WorldGen::clearWorld()` | Seems to clear world data. |
| `0x004a4ce0` | `int32_t WorldGen::CanKillTile(int32_t arg1, int32_t arg2, int32_t arg3)` |  |
| `0x004a997c` | `int32_t WorldGen::ExplodeMine(int32_t arg1, u32 arg2)` |  |
| `0x004a9b1c` | `void WorldGen::GrowPumpkin(u32 X, u32 Y, s32 id)` | Equivalent to `Terraria.WorldGen.GrowPumpkin()`. |
| `0x004b0324` | `int32_t WorldGen::SmoothWorld()` |  |
| `0x004b75e0` | `void PlacePumpkin(u32 X, u32 Y)` | Equivalent to `Terraria.WorldGen.PlacePumpkin()`. |
| `0x004bc550` | `int32_t WorldGen::generateWorld()` |  |
| `0x004cb5dc` | `void LoadWorldFileHeader(FileReader* reader, int32_t arg2)` |  |
| `0x004d529c` | `void LoadWorldFileHeader2(FileReader* reader, int32_t arg2)` |  |
| `0x004da27c` | `void WorldGen::randomBackgrounds()` |  |
| `0x004e9f7c` | `int32_t WorldGen::KillTile2(u32 x, u32 y)` |  |
| `0x004ea4d4` | `void WorldGen::KillTile(u32 x, u32 y, bool flag1, bool flag2, bool flag3, bool flag4)` |  |
| `0x004fe1e8` | `void WorldGen::loadWorld(FileReader* reader)` |  |
| `0x00502f34` | `void** tinyxml2::XMLDocument::XMLDocument(struct tinyxml2_XMLNode_VTable** arg1, char arg2, char arg3)` |  |
| `0x00503f28` | `void* tinyxml2::XMLNode::XMLNode(struct tinyxml2_XMLNode_VTable** arg1, int32_t arg2)` |  |
| `0x00506370` | `int32_t Collision::SwitchTiles(int32_t* arg1, int32_t arg2, int32_t arg3, int32_t arg4 @ r7, int32_t* arg5 @ r9, int96_t arg6 @ q0, int32_t arg7)` |  |
| `0x005068a8` | `int32_t Collision::WetCollision(int32_t* arg1, int32_t arg2, int32_t arg3)` |  |
| `0x0050d93c` | `int32_t GameState::OnActivate()` |  |
| `0x0050e780` | `int32_t GameState::GetStateFlags()` |  |
| `0x0050f170` | `void* GameState::Draw(GameState* arg1)` | Stored in a vtable, called in `StateManager::Draw` at `0x001f6fbc` via `blx r1`. |
| `0x0050f554` | `bool GameState::Update(void* arg1)` |  |
| `0x0050fc9c` | `void* GameState::GameState(GameState* gameState)` |  |
| `0x00510a0c` | `uint32_t BaseMenuState::Draw(BaseMenuState* arg1)` |  |
| `0x00510b38` | `int32_t BaseMenuState::Update(BaseMenuState* menuState)` |  |
| `0x00510b80` | `BaseMenuState* BaseMenuState::BaseMenuState(BaseMenuState* menuState, String* str, int32_t* arg3, uint32_t arg4, int32_t arg5)` | Seems to be an intermediate stage for `BaseMenu::BaseMenu`. |
| `0x00512d48` | `int32_t Texture2D::loadTexture(Texture* arg1, String* str)` |  |
| `0x005134fc` | `int32_t* Texture2D::makePowerOfTwo(void* arg1)` | Expands the mobile function `Texture2D::ConvertRGB888toRGBA8888` |
| `0x00513a44` | `int32_t Texture2D::UpdateTextureData(Texture* arg1, u32 arg2, u32 arg3, u8* arg4, int64_t arg5)` |  |
| `0x00513e1c` | `int32_t Texture2D::SetDataNoBindCheck(Texture* tex, u32 width, u32 height, u8* newImageData, u16 imageFormat, int32_t arg6)` |  |
| `0x00513f50` | `int32_t Texture2D::IsBound(Texture* arg1)` |  |
| `0x005140a4` | `void Texture2D::getPixel(Colour* colour, Texture* texture, int32_t arg3, int32_t arg4, int32_t arg5 @ r6, int32_t arg6 @ r12)` | Does not match the mobile function, but seems to do the same thing.  |
| `0x005144d8` | `Texture* Texture2D::Texture2D(Texture* arg1, String* arg2)` |  |
| `0x00517628` | `int32_t ?::PlayWorld(int32_t* arg1)` | On mobile its either `WorldSizeMenu::PlayWorld` or `WorldMenu::PlayWorld` |
| `0x005186dc` | `uint32_t WorldView::DrawItemText(int32_t arg1, int32_t arg2 @ r9)` |  |
| `0x0051894c` | `uint32_t WorldView::DrawNPCHouse(void* arg1)` |  |
| `0x00519594` | `int32_t WorldView::CalculateView(void* arg1, int32_t arg2, int32_t* arg3, int32_t* arg4, int32_t arg5 @ q4)` |  |
| `0x0051e0e8` | `int32_t WorldView::DrawMinimapVisibility(void* arg1, int32_t arg2 @ r7)` |  |
| `0x005221f0` | `int32_t WorldView::DrawWires(void* arg1 @ r5)` |  |
| `0x00522648` | `void WorldView::DrawWorld(void* arg1)` |  |
| `0x00523aac` | `uint32_t FullVersion::GetIsFullVersion(void* arg1)` | Only called from `Achievements::AchievementSystem::Award`, on mobile its called from a million other places. |
| `0x00524028` | `int32_t InputManager::IsButtonPressed(void* arg1, int32_t arg2)` |  |
| `0x00524c4c` | `s32 ShopItemSlotCount()` | Returns the number of slots in a store. (ItemCount + 5) |
| `0x005252ec` | `bool StringCompare(String* str1, char* rawString)` |  |
| `0x0052dd9c` | `int32_t NPC::getHeadTextureId(void* arg1)` |  |
| `0x005313e8` | `int32_t Tile::left(int32_t arg1, int32_t count)` |  |
| `0x00531448` | `int32_t Tile::right(int32_t arg1, int32_t count)` |  |
| `0x00532a94` | `bool PlayerHasQuestFish(int32_t arg1, Player* arg2)` | Calls `PlayerHasItem()` with `GetQuestFishId()`. |
| `0x00532ab0` | `bool Player::HasItem(Player* player, u32 itemId)` | Returns if `player` has an item with a given `itemId`. |
| `0x005337f0` | `int32_t Gamepad::IsPressed(int32_t* arg1, char* arg2)` |  |
| `0x00538644` | `int32_t MenuBackground::~MenuBackground2(int32_t arg1)` |  |
| `0x00538b48` | `int32_t BaseMenu::Draw2_2(int32_t arg1)` |  |
| `0x00550944` | `uint32_t _INIT_140()` | No call references, the name is from the mobile version. |
| `0x00553ae8` | `uint32_t ClearAll()` | Clears a bunch of stuff like, audio, Chests, Items and more. |
| `0x00564c90` | `int32_t png_error(char* arg1, void* arg2, int32_t arg3 @ r6, int32_t arg4 @ r10)` |  |
| `0x00565068` | `void png_free(void* arg1, int32_t* arg2)` |  |
| `0x005694f0` | `int32_t png_image_begin_read_from_memory(int32_t* arg1, int32_t arg2, int32_t arg3)` |  |
| `0x0056970c` | `int32_t png_image_error(int32_t* arg1, char* arg2)` |  |
| `0x00569774` | `void png_image_finish_read(int32_t* arg1, int32_t arg2, int32_t arg3, int32_t arg4, int32_t arg5)` |  |
| `0x00569988` | `void png_image_free(int32_t* arg1)` |  |
| `0x0056aa44` | `void png_malloc(char* arg1, uint32_t arg2)` |  |
| `0x0056d1e8` | `int32_t png_safe_execute(int32_t* arg1, int32_t arg2, int32_t arg3)` |  |
| `0x0056d2d8` | `int32_t png_safecat(char* arg1, int32_t arg2, int32_t arg3, char* arg4)` |  |
| `0x0056f110` | `int32_t png_set_quantize(uint32_t arg1, void* arg2, uint32_t arg3, uint32_t arg4, char* arg5 @ r4, int32_t arg6 @ r5, int32_t arg7 @ r6, int32_t arg8 @ r7, int32_t* arg9 @ r8, int32_t* arg10 @ r9, int32_t arg11 @ r10, void* arg12 @ r12, int32_t* arg13, int32_t arg14, void* arg15, int32_t arg16, int32_t arg17, int32_t arg18, int32_t arg19, int32_t arg20, int32_t arg21, int32_t arg22, int32_t arg23, int32_t arg24, int32_t arg25)` | No call references, no variable reference. |
| `0x00570860` | `int32_t png_warning(void* arg1, char* arg2)` |  |
| `0x0057a018` | `void O::Event<Widget*>::fire(void* arg1, int32_t arg2)` |  |
| `0x005a3cc8` | `ContentLoader* ContentLoader::ContentLoader_Check()` | Returns `&imageLoader`, may also call `ClearImageLoader()`. |
| `0x005a3d38` | `int32_t TerrariaAtlas::TerrariaAtlas_Check()` |  |
| `0x005afe80` | `int32_t* QueryInstruction::ToString(int32_t* arg1, int32_t* arg2)` | *Verify, probably 3ds specific GPU instructions, do it does not match the mobile function. |
