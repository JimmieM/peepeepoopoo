using System;
using System.Collections.Generic;
using peepeepoopoo.Models.Achievements;

namespace peepeepoopoo.Constants.Achievements
{
    public class Achievements
    {
        public static List<string> GetAchievementTreeRoots()
        {
            return new List<string>
            {
                "Players", "Pets", "Battles"
            };
        }

        public static List<Achievement> GetAllAchievements()
        {
            var achievements = new List<Achievement>();
            achievements.Add(new Achievement(1, "Getting Started", "Win a PvP Battle", 10));
            achievements.Add(new Achievement(2, "That wasn't hard!", "Win a PvE Battle", 10));
            return achievements;
        }
    }
}

//0 => [
//        'name' => 'Getting started',
//        'description' => 'Win a PvP battle',
//        'achievement' => [
//          'amount' => 1
//        ],
//        'reward' => [
//          'bitfunds' => true,
//          'bitfunds_amount' => 20

//        ],
//        'earned' => false,
//        'achievement_id' => '24234',
//        'unlocked' => true,
//        'icon' => 15,
//        'tree_root' => 'pets',
//        'sub_root' => 'battles'
//      ],
//      1 => [
//        'name' => "That wasn't hard!",
//        'description' => 'Win a PvE battle',
//        'achievement' => [
//          'amount' => 1
//        ],
//        'reward' => [
//          'bitfunds' => true,
//          'bitfunds_amount' => 20

//        ],
//        'earned' => false,
//        'achievement_id' => '234',
//        'unlocked' => true,
//        'icon' => 15,
//        'tree_root' => 'pets',
//        'sub_root' => 'battles'
//      ],
//      2 => [
//        'name' => "A challenging combatant",
//        'description' => 'Defeat a stage 3 pet with a stage 2 pet of yours.',
//        'achievement' => [
//          'amount' => 1,
//          'stage_required' => 2,
//          'staged_against' => 3
//        ],
//        'reward' => [
//          'title' => true,
//          'title_name' => 'Challenger'

//        ],
//        'earned' => false,
//        'achievement_id' => '21333',
//        'unlocked' => true,
//        'icon' => 15,
//        'tree_root' => 'pets',
//        'sub_root' => 'battles'
//      ],
//      3 => [
//        'name' => 'Rabbit or humanoid?',
//        'description' => 'Win against 3 rabbits in pet battles',
//        'achievement' => [
//          'pet_type' => 2,
//          'amount' => 3
//        ],
//        'reward' => [
//          'attack' => true,
//          'attack_name' => 'Chew',
//          'attack_id' => 5

//        ],
//        'earned' => false,
//        'achievement_id' => '22221111',
//        'unlocked' => true,
//        'icon' => 50,
//        'tree_root' => 'pets',
//        'sub_root' => 'battles'
//      ],
//      4 => [
//        'name' => "Freakin' squirells",
//        'description' => 'Win against 5 squirells in pet battles',
//        'achievement' => [
//          'pet_type' => 4,
//          'amount' => 5
//        ],
//        'reward' => [
//          'bitfunds' => true,
//          'bitfunds_amount' => 40
//        ],
//        'earned' => false,
//        'achievement_id' => '9198',
//        'unlocked' => true,
//        'icon' => 30,
//        'tree_root' => 'pets',
//        'sub_root' => 'battles'
//      ],
//      5 => [
//        'name' => 'Calm Settlement',
//        'description' => 'Raise 3 pets to stage 3',
//        'achievement' => [
//          'stage' => 3,
//          'amount' => 3
//        ],
//        'reward' => [
//          'attack' => true,
//          'attack_name' => 'Chew',
//          'attack_id' => 5
//        ],
//        'earned' => false,
//        'achievement_id' => '110322',
//        'unlocked' => true,
//        'icon' => 25,
//        'tree_root' => 'pets',
//        'sub_root' => 'stages'
//      ],
//      6 => [
//        'name' => 'Insane progression',
//        'description' => 'Reach level 10',
//        'achievement' => [
//          'level' => 10,
//        ],
//        'earned' => false,
//        'achievement_id' => '238722',
//        'unlocked' => true,
//        'icon' => 10,
//        'tree_root' => 'player',
//        'sub_root' => 'level'
//      ],
//      7 => [
//        'name' => 'Sprinting between levels',
//        'description' => 'Reach level 25',
//        'achievement' => [
//          'level' => 25,
//        ],
//        'earned' => false,
//        'achievement_id' => '998822',
//        'unlocked' => true,
//        'icon' => 15,
//        'tree_root' => 'player',
//        'sub_root' => 'level'
//      ],
//      8 => [
//        'name' => "Becoming insane",
//        'description' => 'Reach level 40',
//        'achievement' => [
//          'level' => 40,
//        ],
//        'earned' => false,
//        'achievement_id' => '9982445',
//        'unlocked' => true,
//        'icon' => 25,
//        'tree_root' => 'player',
//        'sub_root' => 'level'
//      ],
//      9 => [
//        'name' => "Just a brief start",
//        'description' => 'Reach level 5',
//        'achievement' => [
//          'level' => 5,
//        ],
//        'earned' => false,
//        'achievement_id' => '998223115',
//        'unlocked' => true,
//        'icon' => 25,
//        'tree_root' => 'player',
//        'sub_root' => 'level'
//      ],
//      10 => [
//        'name' => "Veteran Nanny",
//        'description' => 'Reach level 70',
//        'achievement' => [
//          'level' => 5,
//        ],
//        'earned' => false,
//        'achievement_id' => '9244423',
//        'unlocked' => true,
//        'icon' => 25,
//        'tree_root' => 'player',
//        'sub_root' => 'level'
//      ],
//      11 => [
//        'name' => "Experienced Winner",
//        'description' => 'Win 25 battles with a pet to unlock the feature of using 3 attacks in battle',
//        'achievement' => [
//          'amount' => 25,
//        ],
//        'reward' => [
//          'attack' => true,
//          'attack_name' => 'Use 3 attacks in battles'
//        ],
//        'earned' => false,
//        'achievement_id' => '124423',
//        'unlocked' => true,
//        'icon' => 50,
//        'tree_root' => 'pets',
//        'sub_root' => 'battles'
//      ]
