/*
 * Student ID : 1690701725
 * Name       : ศุภฤกษ์ แก้วพระโอ๊ะ
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Part A Lab 02
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp; // คำนวณเปอร์เซ็น
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");


            string characterName_1 = "Twise";
            int Age = 25;
            int level_1 = 5;
            float attackPower_1 = 15.5f;
            float Health_1 = 30.5f;
            float currentHp_1 = 30.5f;
            double accuracy_1 = 1.75;
            char element_1 = 'F'; // F = ธาตุไฟ
            bool isActive_1 = true;

            Console.WriteLine("===== 1. TWISE =====");
            Console.WriteLine($"Name: {characterName_1}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Level: {level_1}");
            Console.WriteLine($"AttackPower: {attackPower_1}");
            Console.WriteLine($"MaxHp: {Health_1}");
            Console.WriteLine($"CurrentHp: {currentHp_1}");
            Console.WriteLine($"Accuracy: {accuracy_1}");
            Console.WriteLine($"Element: {element_1}");
            Console.WriteLine($"Combat ready: {(isActive_1 ? " Ready " : "Not Ready")}");
            Console.WriteLine();

            string characterName_2 = "Hamov";
            int Age_2 = 19;
            int level_2 = 10;
            float attackPower_2 = 30.5f;
            float Health_2 = 45.5f;
            float currentHp_2 = 45.5f;
            double accuracy_2 = 3.75;
            char element_2 = 'L'; // L = ธาตุแสง
            bool isActive_2 = true;

            Console.WriteLine("===== 2. HAMOV =====");
            Console.WriteLine($"Name: {characterName_2}");
            Console.WriteLine($"Age: {Age_2}");
            Console.WriteLine($"Level: {level_2}");
            Console.WriteLine($"AttackPower: {attackPower_2}");
            Console.WriteLine($"MaxHp: {Health_2}");
            Console.WriteLine($"CurrentHp: {currentHp_2}");
            Console.WriteLine($"Accuracy: {accuracy_2}");
            Console.WriteLine($"Element: {element_2}");
            Console.WriteLine($"Combat ready: {(isActive_2 ? " Ready " : "Not Ready")}");
            Console.WriteLine();

            string characterName_3 = "Shadow";
            int Age_3 = 28;
            int level_3 = 13;
            float attackPower_3 = 33.5f;
            float Health_3 = 48.5f;
            float currentHp_3 = 48.5f;
            double accuracy_3 = 4.75;
            char element_3 = 'D'; // D = ธาตุมืด
            bool isActive_3 = true;

            Console.WriteLine("===== 3. SHADOW =====");
            Console.WriteLine($"Name: {characterName_3}");
            Console.WriteLine($"Age: {Age_3}");
            Console.WriteLine($"Level: {level_3}");
            Console.WriteLine($"AttackPower: {attackPower_3}");
            Console.WriteLine($"MaxHp: {Health_3}");
            Console.WriteLine($"CurrentHp: {currentHp_3}");
            Console.WriteLine($"Accuracy: {accuracy_3}");
            Console.WriteLine($"Element: {element_3}");
            Console.WriteLine($"Combat ready: {(isActive_3 ? " Ready " : "Not Ready")}");
            Console.WriteLine();

            string characterName_4 = "Shaman";
            int Age_4 = 31;
            int level_4 = 17;
            float attackPower_4 = 41.5f;
            float Health_4 = 60.5f;
            float currentHp_4 = 60.5f;
            double accuracy_4 = 6.75;
            char element_4 = 'W'; // W = ธาตุน้ำ
            bool isActive_4 = true;

            Console.WriteLine("===== 4. SHAMAN =====");
            Console.WriteLine($"Name: {characterName_4}");
            Console.WriteLine($"Age: {Age_4}");
            Console.WriteLine($"Level: {level_4}");
            Console.WriteLine($"AttackPower: {attackPower_4}");
            Console.WriteLine($"MaxHp: {Health_4}");
            Console.WriteLine($"CurrentHp: {currentHp_4}");
            Console.WriteLine($"Accuracy: {accuracy_4}");
            Console.WriteLine($"Element: {element_4}");
            Console.WriteLine($"Combat ready: {(isActive_4 ? " Ready " : "Not Ready")}");
            Console.WriteLine();


        }
    }
}
