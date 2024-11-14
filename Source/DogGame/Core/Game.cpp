// Dog Game. Copyright VeveryCold. All Rights Reserved.

#include "DogGame/Core/Game.h"
#include "DogGame/Core/Grid.h"

DEFINE_LOG_CATEGORY_STATIC(LogGame, All, All);

using namespace Dog;

Game::Game(const Settings& settings) : c_settings(settings) 
{
    m_grid = MakeShared<Grid>(settings.gridDims);
}
 