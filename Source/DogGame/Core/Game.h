// Dog Game. Copyright VeveryCold. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Types.h"

namespace Dog
{

class Grid;

class Game
{
public:
    Game(const Settings& settings); 
    TSharedPtr<Grid> grid() const { return m_grid; }

private:
    const Settings c_settings;
    TSharedPtr<Grid> m_grid;
};
}  // namespace Dog